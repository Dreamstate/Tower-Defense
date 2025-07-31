using UnityEngine;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;
public class PauseMenu : MonoBehaviour
{

    public GameObject pauseMenuUI;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.P))
        {
            TogglePause();
        }
    }

    public void TogglePause()
    {
        pauseMenuUI.SetActive(!pauseMenuUI.activeSelf);

        if (pauseMenuUI.activeSelf)
        {
            Time.timeScale = 0f; // Pause the game
        }
        else
        {
            Time.timeScale = 1f; // Resume the game
        }
    }

    public void Retry()
    {
        TogglePause();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Menu()
    {
        Debug.Log("Loading Main Menu");
    }
}
