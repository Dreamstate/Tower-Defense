using UnityEngine;
using UnityEditor.EventSystems;
using UnityEngine.EventSystems;

public class Node : MonoBehaviour
{
    public Color hoverColor;
    public Color notEnoughMoneyColor;
    public Vector3 positionOffset;
    private Color originalColor;

    [Header("Optional")]
    public GameObject turret;
    private Renderer rend;
    BuildManager buildManager;


    void Start()
    {
        originalColor = GetComponent<Renderer>().material.color;
        rend = GetComponent<Renderer>();
        buildManager = BuildManager.instance;
    }

    public Vector3 GetBuildPosition()
    {
        return transform.position + positionOffset;
    }

    void OnMouseDown()
    {
        if (EventSystem.current.IsPointerOverGameObject())
            return;

        if (!buildManager.CanBuild)
            return;

        if (turret != null)
        {
            Debug.Log("Node already has a turret. - TODO Display on screen.");
            return;
        }

        buildManager.BuildTurretOn(this);
    }
    void OnMouseEnter()
    {
        if (EventSystem.current.IsPointerOverGameObject())
            return;

        if (!buildManager.CanBuild)
            return;

        if (buildManager.HasMoney)
            rend.material.color = hoverColor;
        else
            rend.material.color = notEnoughMoneyColor;

    }

    void OnMouseExit()
    {
        rend.material.color = originalColor;
    }
}
