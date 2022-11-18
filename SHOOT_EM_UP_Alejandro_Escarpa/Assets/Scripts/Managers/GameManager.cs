using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject gameOverMenu;
    [SerializeField] MouseVisibility mouse;
    [SerializeField] PowerUpSpawner powerSpawner;

    [SerializeField] PointsManager points;

    private UIHealth uiHealth;
    private PlayerHealth playerHealth;



    private void Start()
    {

        uiHealth = GameObject.FindGameObjectWithTag("UIHealth").GetComponent<UIHealth>();
        playerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
    }

    public void GameOver()
    {
        mouse.MouseVisible();
        SavePoints();
        gameOverMenu.SetActive(true);
        DestroyEnemies();
        DestroyLasers();
        powerSpawner.StopAllCoroutines();

        if(PlayerPrefs.GetInt("Record", 0) < points.GetPoints())
            PlayerPrefs.SetInt("Record", points.GetPoints());
    }

    private void DestroyEnemies()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");

        foreach(GameObject enemy in enemies)
        {
            Destroy(enemy);
        }
    }
    private void DestroyLasers()
    {
        GameObject[] lasers = GameObject.FindGameObjectsWithTag("Laser");

        foreach(GameObject laser in lasers)
        {
            Destroy(laser);
        }
    }

    #region Player
    public int GetPlayerHealth()
    {
        return playerHealth.GetHealth();
    }

    public void loseHealth()
    {
        uiHealth.loseHealth();
    }

    public void RecoverHealth()
    {
        uiHealth.recoverHealth();
    }

    public void RecoverFullHealth()
    {
        uiHealth.recoverFullHealth();
    }

    public void ActiveInvulnerability(float time)
    {
        playerHealth.StartCoroutine(playerHealth.Invulnerable(time));
        uiHealth.StartCoroutine(uiHealth.InvulnerabilityHealth(time));
    }

    #endregion

    #region Points
    public void SetCanGetPoints(bool value)
    {
        points.SetCanGetPoints(value);
    }

    public void IncreasePoints(int value)
    {
        points.IncreasePoints(value);
    }

    public int GetRoundPoints()
    {
        return points.GetPoints();
    }
    #endregion

    #region Data

    public void SavePoints()
    {
        int currentPlayerPoints = points.GetCurrentPlayerPoints();
        int roundPoints = points.GetPoints();

        currentPlayerPoints += roundPoints;

        PlayerPrefs.SetInt("Points", currentPlayerPoints);
    }

    #endregion
}
