using UnityEngine;

public class Shop : MonoBehaviour
{
    public TurretBlueprint standardTurret;
    public TurretBlueprint advancedTurret;
    public TurretBlueprint missileLauncher;
    public TurretBlueprint laserBeamer;
    BuildManager buildManager;

    void Start()
    {
        buildManager = BuildManager.instance;
    }

    public void SelecteStandardTurret()
    {
        Debug.Log("Selected Turret Selected!");
        buildManager.SelectTurretToBuild(standardTurret);
    }
    public void SelecteAdvancedTurret()
    {
        Debug.Log("Selected Advanced Turret Selected!");
        buildManager.SelectTurretToBuild(advancedTurret);
    }

    public void SelecteMissileLauncher()
    {
        Debug.Log("Selected Missile Launcher Selected!");
        buildManager.SelectTurretToBuild(missileLauncher);
    }
    public void SelecteLaserBeamer()
    {
        Debug.Log("Selected Laser Beamer Selected!");
        buildManager.SelectTurretToBuild(laserBeamer);
    }
}
