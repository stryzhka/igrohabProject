using System;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] private int HealthPoints;
    [SerializeField] private int Lives;
    void Start()
    {
        
    }


    void Update()
    {
        
    }

    public int GetHealthPoints()
    {
        return HealthPoints;
    }

    public void SetHealthPoints(int set)
    {
        HealthPoints = set;
    }
}
