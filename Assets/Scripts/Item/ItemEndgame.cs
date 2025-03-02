using UnityEngine;

public class Endgame : Item
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField] private GameObject UiPanel;
    [SerializeField] private GameObject WonPanel;


    public override void ItemAction()
    {
        Debug.Log("COOL");

            UiPanel.SetActive(false);
            WonPanel.SetActive(true);
            //Time.timeScale = 0;
        
    }
}
