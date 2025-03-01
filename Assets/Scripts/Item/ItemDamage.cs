using UnityEngine;

public class ItemDamage : Item
{
    public PlayerStatsController PlayerStatsController;

    public override void ItemAction()
    {
        Debug.Log("DAMAAGEE");
        PlayerStatsController.DoDamage(Change);
        Destroy(gameObject);
    }
}
