using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager instance;
    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("More than one BuildManager in scene!");
            return;
        }
        instance = this;
    }

    public GameObject buildEffect;
    private TurretBlueprint turretToBuild;
    private Node selectedNode;
    public TurretMenuUI turretMenuUI;
    public bool CanBuild { get { return turretToBuild != null; } }
    public bool HasMoney { get { return PlayerStats.Money >= turretToBuild.cost; } }

    public void SelectNode(Node node)
    {
        if (selectedNode == node)
        {
            DeselectNode();
            return;
        }

        selectedNode = node;
        turretToBuild = null;

        turretMenuUI.SetTarget(node);
    }

    public void DeselectNode()
    {
        selectedNode = null;
        turretMenuUI.Hide();
    }

    public void SelectTurretToBuild(TurretBlueprint tb)
    {
        turretToBuild = tb;

        DeselectNode();
    }

    public TurretBlueprint GetTurretToBuild()
    {
        return turretToBuild;
    }
}
