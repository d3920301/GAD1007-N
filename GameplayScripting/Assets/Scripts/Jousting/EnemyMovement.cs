/* 
* Enemy Movement Speed Ramp
* currentRoundTimer / 
*/

using UnityEngine;

public class EnemyMovement : Movement
{
    private enum Difficulty {Easy, Medium, Hard};
    [SerializeField] private bool randDifficulty = true;
    [SerializeField] private Difficulty DIF_difficulty;
    private float origDif = 0.1f;
    public float difficulty = 0.1f;

    protected override void Awake()
    {
        base.Awake();

        GetComponent<Health>().OnEnemyDied += () => OnEnemyDied();

        // Subscribe to OnRoundEnd event so we can reset the difficulty variable.
        FindFirstObjectByType<RoundManager>().m_RoundEnded.AddListener(OnRoundEnd); 
    }

    private void Start()
    {
        if (randDifficulty)
        {
            DIF_difficulty = (Difficulty)Random.Range((float)Difficulty.Easy, (float)Difficulty.Hard);
        }

        origDif = CalculateDifficultyMultiplyer(DIF_difficulty);
    }

    protected override void Move()
    {
        //Debug.Log("Enemy Movement");

        // See player Move();
        if (!canMove)
        {
            if (GetVelocity() > 0.5)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(GetVelocity() * 0.95f, 0);
                //Debug.Log(name + " is slowing down!");
            }
            else if (GetVelocity() != 0)
            {
                GetComponent<Rigidbody2D>().velocity = Vector2.zero;
                //Debug.Log(name + " has stopped!");
            }
            //Debug.Log("Enemy shouldn't move");
            return;
        }

        difficulty += origDif;

        rb.AddForce(Vector2.right * difficulty);
    }

    private void OnRoundEnd()
    {
        difficulty = origDif;
    }

    private void OnEnemyDied()
    {
        SetCanMove(false);
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
    
        // Play death animation
    }

    private float CalculateDifficultyMultiplyer(Difficulty pDifficulty)
    {
        float difficulty = 0.1f;

        switch (pDifficulty)
        {
            case Difficulty.Easy:
                difficulty = Random.Range(0.1f, 0.35f);
                break;
            case Difficulty.Medium:
                difficulty = Random.Range(0.35f, 0.6f);
                break;
            case Difficulty.Hard:
                difficulty = Random.Range(0.6f, 0.85f);
                break;
            default:
                break;
        }

        return difficulty;
    }
}
