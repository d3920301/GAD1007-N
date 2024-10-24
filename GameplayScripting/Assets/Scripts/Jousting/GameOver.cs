using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public void LoadMainMenu()
    {
        //Debug.Log("Loading Main Menu");

        // Reset the gamesWon variable here otherwise it shows up as 0 on the GameOver screen.
        FindAnyObjectByType<RoundManager>().m_GameLost.Invoke();

        SceneManager.LoadScene(0);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
