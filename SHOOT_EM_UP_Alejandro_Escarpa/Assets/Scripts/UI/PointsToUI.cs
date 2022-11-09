using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PointsToUI : MonoBehaviour
{
    [SerializeField] GameManager manager;
    [SerializeField] float speed;
    [SerializeField] TextMeshProUGUI pointsTxt;

    bool isCountFinish = false;
    int roundPoints;
    float pointsCount = 0;

    private void Start()
    {
        roundPoints = manager.GetRoundPoints();
    }

    private void Update()
    {
        if (pointsCount <= roundPoints && !isCountFinish)
        {
            pointsCount += Time.deltaTime * speed;
            pointsTxt.text = pointsCount.ToString("0");
        }

        if(pointsCount > roundPoints)
        {
            isCountFinish= true;
            pointsCount = roundPoints;
        }
    }

}
