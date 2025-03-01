using UnityEngine;
using UnityEngine.UI;

public class UiController : MonoBehaviour
{
    [SerializeField] private PlayerStatsController PlayerStatsController;
    [SerializeField ] private Text HealthPointsText;

    [SerializeField ] private Text ScoreText;

    [SerializeField] private GameObject AlivePanel;
    [SerializeField] private GameObject DeadPanel; 

    void Start()
    {
        
    }

    void Update()
    {
        HealthPointsText.text = PlayerStatsController.GetHealthPointsText();
        ScoreText.text = PlayerStatsController.GetScoreText();
    }

    public void DeadState()
    {
        AlivePanel.SetActive(false);
        DeadPanel.SetActive(true);
    }
}
