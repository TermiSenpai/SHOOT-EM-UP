using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Shop : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI pointsTxt;
    int playerPoints;

    private void Start()
    {
        getTotalPoints();
        updateTxt();
    }

    public void buySomething(int price)
    {

        if (playerPoints >= price)
        {
            playerPoints -= price;
        }
        savePoints();
        updateTxt();
    }

    public void updateTxt()
    {
        getTotalPoints();
        pointsTxt.text = $"Player points: {playerPoints} points";
    }

    public void savePoints()
    {
        PlayerPrefs.SetInt("Points", playerPoints);
    }

    private void getTotalPoints()
    {
        playerPoints = PlayerPrefs.GetInt("Points", 0);
    }
}

