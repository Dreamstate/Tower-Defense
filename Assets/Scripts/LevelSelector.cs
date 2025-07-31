using UnityEngine;

public class LevelSelector : MonoBehaviour
{
    public SceneFader sceneFader;

    public void SelectLevel(string levelName)
    {
        sceneFader.FadeTo(levelName);
    }
}
