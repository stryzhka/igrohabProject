using System;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] private int HealthPoints;
    [SerializeField] private int Lives;

    [SerializeField] private int Score;

    [SerializeField] private float SpeedBonus;
    void Awake()
    {
        //DontDestroyOnLoad(this.gameObject);
        
    }


    void Update()
    {
        
    }

    public int GetLives()
    {
        return Lives;
    }
    public void SetLives(int set)
    {
        Lives = set;
    }
    public float GetSpeedBonus()
    {
        return SpeedBonus;
    }

    public void SetSpeedBonus(float set)
    {
        SpeedBonus = set;
    }
    public int GetHealthPoints()
    {
        return HealthPoints;
    }

    public void SetHealthPoints(int set)
    {
        HealthPoints = set;
    }

    public int GetScore()
    {
        return Score;
    }

    public void SetScore(int set)
    {
        Score = set;
    }
}
