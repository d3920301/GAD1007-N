/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
* ROUND FLOW                                                                                                                                                      *
* 1: Pre-Round - Setup player, and enemy here. The countdown is part of this.                                                                                     *
* 2: Round Start - This is before the collision. Both parties move and can control the power bar here.                                                            *
* 3a: Round End - This is after the collision, and both parties are alive. We go back to the pre-round stage here.                                                *
* --------------------------------------------------------------------------------------------------------------------------------------------------------------- *
* 3b: Final Round End - This happens after the collision, and either both parties or just the player is dead.                                                     *
* 4b: Game Over - Show the game over screen, and give the playe the options to either quit, or try again.                                                         *
* --------------------------------------------------------------------------------------------------------------------------------------------------------------- *
* 4c: Victory Level - This happens after the collision, and the enemy is dead.                                                                                    *
* 5c: Town Level - This happens after the victory scene. The player can get hints, buy gear, and prepare for their next fight. We go to the pre-round after this. *
* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */

using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

[System.Serializable]
public class EntityEvent : UnityEvent<GameObject, GameObject>
{
}

public class RoundManager : MonoBehaviour
{
    public EntityEvent m_EntitiesSpawned;
    public UnityEvent m_RoundEnded;
    public UnityEvent m_GameWon;
    public UnityEvent m_GameLost;

    [SerializeReference] GameObject gameOverUI = null;
    [SerializeField] GameObject[] entitys;
    private GameObject[] entityReferences;
    private GameObject entity1;
    private GameObject entity2;
    [SerializeField] GameObject[] spawnPoints;
    [SerializeField] float countdownAmount;

    private bool playerAlive = true;
    private bool enemyAlive = true;
    //private bool roundStarted = false;

    private void Awake()
    {
        // Round manager has to instanciate and store player and enemy objects.

        // Find end of track maker;
        // Subscribe to its event;
        foreach (GameObject s in spawnPoints)
        {
            s.GetComponent<EndRound>().OnEndRound += RoundEnd;
        }

        // Find and reference 
    }

    // Start is called before the first frame update
    private void Start()
    {
        // Compound assignment (IDE0054 and IDE0074) IT means if event is null then add a new entity event ^^
        m_EntitiesSpawned ??= new EntityEvent();

        PreRound();
    }

    private void PreRound()
    {
        //Debug.Log("Calling PreRound");

        // Spawn Player. Spawn Enemy. We need to offset the spawn pos to avoid EndRound being called.
        var entity1Transform = spawnPoints[0].transform.position + new Vector3(-1.25f, 0.0f, 1.0f);
        entity1 = Instantiate(entitys[0], entity1Transform, spawnPoints[0].transform.rotation);
        var entity2Transform = spawnPoints[1].transform.position + new Vector3(1.25f, 0.0f, 1.0f);
        entity2 = Instantiate(entitys[1], entity2Transform, spawnPoints[1].transform.rotation);

        m_EntitiesSpawned.Invoke(entity1, entity2);

        // Store references to active entities. <- We don't need if we cache before we instanciate.
        // for (int i = 0; i < entitys.GetLength(0); i++)
        // {
        //     Debug.Log(entitys.GetLength(0) + " " +i);
        //     print(entitys[i]);
        //     //entityReferences[i] = entitys[i];
        // }
        // Subscribe to death stuff from their health components
        entity1.GetComponent<Health>().OnPlayerDied += () => {/*Debug.Log("Player Died");*/ playerAlive = false; entity1.GetComponent<Movement>().SetCanMove(false);};
        entity2.GetComponent<Health>().OnEnemyDied += () => {/*Debug.Log("Enemy Died");*/ enemyAlive = false; entity2.GetComponent<Movement>().SetCanMove(false);};


        // Start Countdown
        StartCountdownTimer(countdownAmount);
    }

    // Wait for the countdown timer to tell us to start
    private void RoundStart()
    {
        //Debug.Log("Round Start");
        //roundStarted = true;
        // foreach (GameObject entity in entityReferences)
        // {
        //     entity.GetComponent<Movement>().SetCanMove(true);
        // }
        entity1.GetComponent<Movement>().SetCanMove(true);
        entity2.GetComponent<Movement>().SetCanMove(true);

        // Enable the ability to end the round
        spawnPoints[0].GetComponent<EndRound>().canEndRound = true;
        spawnPoints[1].GetComponent<EndRound>().canEndRound = true;
    }

    private void RoundEnd()
    {
        //Debug.Log("End Round");

        entity1.GetComponent<Movement>().ZeroVelocity();
        entity1.GetComponent<Movement>().SetCanMove(false);
        entity2.GetComponent<Movement>().ZeroVelocity();
        entity2.GetComponent<Movement>().SetCanMove(false);

        spawnPoints[0].GetComponent<EndRound>().canEndRound = false;
        spawnPoints[1].GetComponent<EndRound>().canEndRound = false;



        if (!playerAlive)
        {
            //Debug.Log("HelLO!");
            //m_GameLost.Invoke(); Moved to the Main Menu button on game over! Should probably do that if we add a pause menu too.
            FinalRoundEnd();
        }
        else if (!enemyAlive)
        {
            m_GameWon.Invoke();
            VictoryLevel();
        }
        else
        {
            m_RoundEnded.Invoke();
        
            //Debug.Log("RoundEnd > PreRound");
            RoundCounter roundCounter = FindObjectOfType<RoundCounter>();
            roundCounter.GetComponent<RoundCounter>().IncrementCounter();

            // Fade to black?
            
            int nextRoundDelay = 3;
            SetupNextRound(nextRoundDelay);
        }
    }

    private void SetupNextRound(float delay = 0)
    {
        // Move entities back to their stating positions
        entity1.transform.position = spawnPoints[0].transform.position;
        entity2.transform.position = spawnPoints[1].transform.position;

        // @TODO We need to reset the enemies difficulty multiplier after each round.
        foreach (GameObject gameObject in entitys)
        {
            if (gameObject.GetComponent<EnemyMovement>())
            {
                gameObject.GetComponent<EnemyMovement>().difficulty = 0.1f;
            }
        }

        StartCountdownTimer(countdownAmount);
    }

    private void FinalRoundEnd()
    {
        //Debug.Log("Game Over");

        if (gameOverUI == null)
        {
            SceneManager.LoadScene(0);
            return;
        }

        gameOverUI.SetActive(true);
    }

    private void StartCountdownTimer(float countdownAmount)
    {
        CountdownTimer countdownTimer = FindAnyObjectByType<CountdownTimer>();
        countdownTimer.StartTimer(countdownAmount);
        Invoke(nameof(RoundStart), countdownAmount);
    }

    private void VictoryLevel()
    {
        SceneManager.LoadScene(2);
    }

    private void TownLevel()
    {
        SceneManager.LoadScene(3);
    }
}