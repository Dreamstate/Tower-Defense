using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;
public class RoundSurvived : MonoBehaviour
{
    public TextMeshProUGUI roundsText;

    void OnEnable()
    {
        StartCoroutine(AnimateText());
    }

    IEnumerator AnimateText()
    {
        int round = 0;
        roundsText.text = "0";
        yield return new WaitForSeconds(0.7f);

        while (round < PlayerStats.Rounds)
        {
            round++;
            roundsText.text = round.ToString();
            yield return new WaitForSeconds(0.05f);
        }
    }
}
