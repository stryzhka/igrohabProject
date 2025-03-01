using UnityEngine;
using UnityEngine.UI;

public class UiController : MonoBehaviour
{
    public PlayerStatsController PlayerStatsController;
    public Text HealthPointsText;
    void Start()
    {
        
    }

    void Update()
    {
        HealthPointsText.text = PlayerStatsController.GetHealthPointsText();
    }
}
