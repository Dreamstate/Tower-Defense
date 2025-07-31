using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string levelToLoad = "MainLevel";
    public void Play()
    {
        SceneManager.LoadScene(levelToLoad); // Replace "GameScene" with your actual game scene name
    }

    public void Quit()
    {
        Debug.Log("Exiting Game...");
        Application.Quit();
    }
}
