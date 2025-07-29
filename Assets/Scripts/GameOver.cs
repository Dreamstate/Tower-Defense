using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public TextMeshProUGUI roundsText;
    void OnEnable()
    {
        if (roundsText == null)
        {
            Debug.LogError($"[GameOver] roundsText is NULL on '{name}'");
            return;
        }
        roundsText.text = PlayerStats.Rounds.ToString();
    }

    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Menu()
    {
        Debug.Log("Loading Menu...");
    }

}
