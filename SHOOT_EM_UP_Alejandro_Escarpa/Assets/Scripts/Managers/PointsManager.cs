using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointsManager : MonoBehaviour
{
    [SerializeField] int currentPlayerPoints;
    [SerializeField] int RoundPoints;
    [SerializeField] bool canGetPoints = true;

    private void Start()
    {
        currentPlayerPoints = PlayerPrefs.GetInt("Points", 0);
        RoundPoints = 0;
    }

    public void IncreasePoints(int value)
    {
        if (canGetPoints)
        {
            RoundPoints += value;

        }
    }

    public void SetCanGetPoints(bool value)
    {
        canGetPoints = value;
    }

    public int GetPoints()
    {
        return RoundPoints;
    }

    public int GetCurrentPlayerPoints()
    {
        return currentPlayerPoints;
    }
}
