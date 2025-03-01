using System;
using System.Collections;
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

    void Start()
    {
        
        
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
        CoroutineController.CameraTilt();
        CheckPlayerDead();
    }

    public void Heal(int set)
    {
        PlayerStats.SetHealthPoints(PlayerStats.GetHealthPoints() + set);
        CoroutineController.CameraZoom();
    }

    public void AddSpeedBonus(float bonus)
    {
        CoroutineController.CameraZoomForTime();
        PlayerStats.SetSpeedBonus(bonus);
        StartCoroutine(SpeedBonusBack());
    }


    
    public void AddScore(int set)
    {
        PlayerStats.SetScore(PlayerStats.GetScore() + set);
        CoroutineController.CameraZoom();
    }   

    public string GetHealthPointsText()
    {
        return "Здоровье: " + PlayerStats.GetHealthPoints().ToString();
    }

    public string GetScoreText()
    {
        return "Очки: " + PlayerStats.GetScore().ToString();
    }

    private void CheckPlayerDead(){
        if (PlayerStats.GetHealthPoints() <= 0){
            PlayerDead?.Invoke(SceneController.SceneState.PlayerDead);
            
        }
    }

    

    private IEnumerator SpeedBonusBack()
    {
        yield return new WaitForSeconds(5f);
        PlayerStats.SetSpeedBonus(0f);
    }
}
