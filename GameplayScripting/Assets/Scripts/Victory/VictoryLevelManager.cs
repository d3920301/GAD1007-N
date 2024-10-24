/* * * * * * * * * * * * * * * * * * * * *
* VICTORY SCENE                          *
* Victory scene is for show only         *
* No important information is shown here *
* * * * * * * * * * * * * * * * * * * * */

using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryLevelManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke(nameof(LoadTownScene), 3);
    }

    private void PlayWinAnim()
    {

    }

    private void LoadTownScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
