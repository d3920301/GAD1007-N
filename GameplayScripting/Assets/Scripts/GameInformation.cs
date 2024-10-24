/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * 
* I *THINK* this script manages what enemy the player is currently facing.                               *
* This script *MIGHT* also manage which enemy the player will face next.                                 *
* It's been almost a month since I last thought about this project I have no idea what this script does. * 
* !!! We need to know the next enemy we're going to face a round before we fight them !!!                *
* This is because the audience will give hints about the next fight so the player has time to prepare.   *
* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */

using UnityEngine;
using UnityEngine.SceneManagement;

public class GameInformation : MonoBehaviour
{
    public static Armoury.RPS playerEquipment { get; set; } = Armoury.RPS.Strength;

    // DudEnemy should not be used. It will not have any code associated with it.
    // Enemy 4 should never be used, as it will never be picked (Unity int range is max-exclusive for some reason?)
    public enum Enemy {DudEnemy, Enemy1, Enemy2, Enemy3, Enemy4};

    public static Enemy CurrentEnemy { get; private set; } = Enemy.DudEnemy;
    public static Enemy NextEnemy { get; private set; } = Enemy.DudEnemy;

    private GameObject entity1;
    private GameObject entity2;
    public int gamesWon {get; private set; } = 0;

    private void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("GameInformation");

        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);
        
        // We don't want to overwrite any enemies currenty pending the fight.
        // We use dud enemy becuase nextEnemy cannot be null.
        if (NextEnemy == Enemy.DudEnemy)
        {
            //Debug.Log("GameInformation : Start()\nPickNextEnemy() is run twice in Start() to avoid currentEnemy and nextEnemy from being NULL");

            PickNextEnemy();

            CurrentEnemy = NextEnemy;

            PickNextEnemy();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("Start Called");
        // Subscribe to the OnEnemyDied event so we can push nextEnemy into currentEnemy, and so we can generate a new nextEnemy
        // Health isn't a GameObject. We need to find the game object first, then get the Health component.
        // Enemy and Player should be tagged with their respective tags. Use the tags to find the GameObject, then get the compnent?
        //FindObjectOfType<Health>().OnEnemyDied += PickNextEnemy; // @TODO: This throws an error :(
        //Health thc = GameObject.FindGameObjectWithTag("Player").GetComponent<Health>();// .OnPlayerDied += PickNextEnemy;
        //Debug.Log(thc);
        // We also want this behaviour for if the player dies I guess :|
        //FindObjectOfType<Health>().OnEnemyDied += PickNextEnemy; // @TODO: I guess this one will throw an error as well
        //GameObject.FindGameObjectWithTag("Enemy").GetComponent<Health>().OnEnemyDied += PickNextEnemy;

        // Subscribe to RoundManager instead of individual components.
        

        SceneManager.activeSceneChanged += SceneChanged;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SceneChanged(Scene current, Scene next)
    {
        if (FindAnyObjectByType<RoundManager>())
        {
            RoundManager roundManager = FindAnyObjectByType<RoundManager>();
            roundManager.m_EntitiesSpawned.AddListener(SubscribeToNewEntities);
            roundManager.m_GameWon.AddListener(IncrementGamesWon);
            roundManager.m_GameLost.AddListener(ResetGamesWon);
        }
    }

    private void SubscribeToNewEntities(GameObject passedEntity1, GameObject passedEntity2)
    {

        //Debug.Log("Subscribing to new entities...");

        // We should probably unsubscribe from the old entities...
        


        entity1 = passedEntity1;
        entity2 = passedEntity2;

        entity1.GetComponent<Health>().OnPlayerDied += PickNextEnemy;
        entity2.GetComponent<Health>().OnEnemyDied += PickNextEnemy;
    }

    private void PickNextEnemy()
    {
        CurrentEnemy = NextEnemy;

        //Debug.Log("GameInformation : PickNextEnemy()\ncurrentEnemy: " + CurrentEnemy + "\nPicking next enemy...");

        int r = Random.Range((int)Enemy.Enemy1, (int)Enemy.Enemy4);
        NextEnemy = (Enemy)r;

        //Debug.Log("GameInformation : PickNextEnemy()\nnextEnemy is " + NextEnemy);
    }

    private void IncrementGamesWon()
    {
        //Debug.Log("Incrementing score...");
        gamesWon++;
    }

    private void ResetGamesWon()
    {
        gamesWon = 0;
    }
}
