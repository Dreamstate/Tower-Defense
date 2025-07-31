using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public string sceneToLoad = "LevelSelect";
    public SceneFader sceneFader;
    public void Play()
    {
        sceneFader.FadeTo(sceneToLoad);
    }

    public void Quit()
    {
        Debug.Log("Exiting Game...");
        Application.Quit();
    }
}
