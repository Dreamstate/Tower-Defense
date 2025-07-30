using UnityEngine;

public class TurretMenuUI : MonoBehaviour
{
    public GameObject menuPanel;
    private Node target;

    public void SetTarget(Node _target)
    {
        this.target = _target;

        transform.position = target.GetBuildPosition();
        menuPanel.SetActive(true);
    }

    public void Hide()
    {
        menuPanel.SetActive(false);
    }
}
