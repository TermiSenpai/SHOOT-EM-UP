using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    int health;
    [SerializeField] int maxHealth;

    private void Start()
    {
        health = maxHealth;
    }

    private void CheckHealth()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void loseHealth()
    {
        health--;
        CheckHealth();
    }

}
