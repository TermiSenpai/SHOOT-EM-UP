using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject gameOverMenu;
    [SerializeField] MouseVisibility mouse;

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
        gameOverMenu.SetActive(true);
    }

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

}
