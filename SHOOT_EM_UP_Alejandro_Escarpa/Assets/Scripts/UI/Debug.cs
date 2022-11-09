using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Debug : MonoBehaviour
{
    [SerializeField] private int points;
    [SerializeField] TextMeshProUGUI pointsTxt;

    private void Start()
    {
        getTotalPoints();
    }

    public void savePoints(int value)
    {
        PlayerPrefs.SetInt("Points", value);
    }

    public void GivePoints(int value)
    {
        points += value;
        savePoints(points);
        updateTxt();
    }

    public void ZeroPoints()
    {
        points = 0;
        savePoints(points);
        updateTxt();
    }

    private void updateTxt()
    {
        getTotalPoints();
        pointsTxt.text = $"Player points: {points} points";
    }

    private void getTotalPoints()
    {
        points = PlayerPrefs.GetInt("Points", 0);
    }

}
