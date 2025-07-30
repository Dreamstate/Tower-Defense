using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class TurretMenuUI : MonoBehaviour
{
    public GameObject menuPanel;
    private Node target;
    public TextMeshProUGUI upgradeCostText;
    public TextMeshProUGUI sellAmountText;
    public Button upgradeButton;

    public void SetTarget(Node _target)
    {
        this.target = _target;

        if (!target.isUpgraded)
        {
            upgradeCostText.text = "$" + target.turretBlueprint.upgradeCost.ToString();
            upgradeButton.interactable = true;
        }
        else
        {
            upgradeCostText.text = "MAX";
            upgradeButton.interactable = false;
        }

        sellAmountText.text = "$" + target.turretBlueprint.GetSellAmount().ToString();

        transform.position = target.GetBuildPosition();


        menuPanel.SetActive(true);
    }

    public void Hide()
    {
        menuPanel.SetActive(false);
    }

    public void UpgradeTurret()
    {
        target.UpgradeTurret();
        BuildManager.instance.DeselectNode();
    }

    public void SellTurret()
    {
        target.SellTurret();
        BuildManager.instance.DeselectNode();
    }
}
