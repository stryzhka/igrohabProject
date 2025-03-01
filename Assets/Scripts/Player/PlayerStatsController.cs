using System;
using Unity.VisualScripting.ReorderableList;
using UnityEngine;

public class PlayerStatsController : MonoBehaviour
{
    public PlayerStats PlayerStats;
    public PlayerMovement PlayerMovement;
    public CoroutineController CoroutineController;

    public static event Action<SceneController.SceneState> PlayerDead;
    void OnEnable()
    {
        PlayerMovement.ItemCollisionInvoked += ItemAction;
    }
    void OnDisable()
    {
        PlayerMovement.ItemCollisionInvoked -= ItemAction;
    }

    void Update()
    {
        CheckPlayerDead();
    }

    private void ItemAction(Item itemClass)
    {
        itemClass.ItemAction();
    }
    public void DoDamage(int dmg)
    {
        PlayerStats.SetHealthPoints(PlayerStats.GetHealthPoints() - dmg);
        CoroutineController.CameraTilt();
    }
    public string GetHealthPointsText()
    {
        return "Health: " + PlayerStats.GetHealthPoints().ToString();
    }

    private void CheckPlayerDead(){
        if (PlayerStats.GetHealthPoints() <= 0){
            PlayerDead?.Invoke(SceneController.SceneState.PlayerDead);
        }
    }
}
