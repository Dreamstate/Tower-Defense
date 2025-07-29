using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MoneyUI : MonoBehaviour
{
    public TextMeshProUGUI mondeyText;

    void Update()
    {
        mondeyText.text = "$" + PlayerStats.Money.ToString();
    }
}
