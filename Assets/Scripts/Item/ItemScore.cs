using UnityEngine;

public class ItemScore : Item
{
    public PlayerStatsController PlayerStatsController;
    public override void ItemAction()
    {
        Debug.Log("SCORE");
        PlayerStatsController.AddScore(Change);
        Destroy(gameObject);
    }
}
