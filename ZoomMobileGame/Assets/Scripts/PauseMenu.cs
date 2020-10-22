using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;
    public GameObject left;
    public GameObject right;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void PauseGame ()
    {
        if (GameIsPaused)
        {
            Resume();
        }
        else
        {
            Pause();
        }
    }

    public void Resume ()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        if (ButtonSettings.buttonState)
        {
            left.SetActive(true);
            right.SetActive(true);
        }
    }

    public void Pause ()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        if (ButtonSettings.buttonState)
        {
            left.SetActive(false);
            right.SetActive(false);
        }
    }

    public void LoadMenu ()
    {
        Time.timeScale = 1f;
        GameIsPaused = false;
        SceneManager.LoadScene(0);
    }

    public void QuitGame ()
    {
        Debug.Log("Quitting game...");
        Application.Quit();
    }
}
