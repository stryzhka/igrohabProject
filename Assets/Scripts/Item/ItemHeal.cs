using UnityEngine;

public class ItemHeal : Item
{
    public PlayerStatsController PlayerStatsController;

    public override void ItemAction()
    {
        Debug.Log("HEAL");
        PlayerStatsController.Heal(Change);
        Destroy(gameObject);
    }
}
