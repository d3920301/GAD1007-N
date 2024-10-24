using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    private Canvas canvas = null;

    // Start is called before the first frame update
    void Start()
    {
        canvas = GetComponentInChildren<Canvas>();
        canvas.enabled = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            canvas.enabled = true;
        }
    }

    public void Resume()
    {
        canvas.enabled = false;
    }

    public void Quit()
    {
        Application.Quit();
    }
}
