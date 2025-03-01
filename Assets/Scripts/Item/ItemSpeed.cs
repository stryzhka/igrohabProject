using UnityEngine;

public class ItemSpeed : Item
{
    public PlayerStatsController PlayerStatsController;
    public override void ItemAction()
    {
        Debug.Log("SPEED");
        PlayerStatsController.AddSpeedBonus(Change);
        Destroy(gameObject);
    }
}
