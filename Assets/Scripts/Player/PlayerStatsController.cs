using Unity.VisualScripting.ReorderableList;
using UnityEngine;

public class PlayerStatsController : MonoBehaviour
{
    public PlayerStats PlayerStats;
    public PlayerMovement PlayerMovement;
    public CameraController CameraController;
    void Start()
    {
        PlayerMovement.ItemCollisionInvoked += ItemAction;
    }

    void Update()
    {
        
    }

    private void ItemAction(Item itemClass)
    {
        itemClass.ItemAction();
    }
    public void DoDamage(int dmg)
    {
        PlayerStats.SetHealthPoints(PlayerStats.GetHealthPoints() - dmg);
        StartCoroutine(CameraController.CameraTilt());
    }
    public string GetHealthPointsText()
    {
        return "Health: " + PlayerStats.GetHealthPoints().ToString();
    }
}
