using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
public class UIHealth : MonoBehaviour
{
    [SerializeField] GameObject[] hearths;

    private GameManager manager;

    private void Start()
    {
        manager = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();        
    }

    public void loseHealth()
    {
        int hp = playerHealth();

        hearths[hp].SetActive(false);
    }

    public void recoverHealth()
    {
        int hp = playerHealth();

        hearths[hp].SetActive(true);
    }

    public void recoverFullHealth()
    {
        foreach(GameObject hearth in hearths)
        {
            hearth.SetActive(true);
        }
    }

    private int playerHealth()
    {
        return manager.GetPlayerHealth();
    }
}
