using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    #region variables
    int health;
    [SerializeField] int maxHealth;
    [SerializeField] float invulnerabilityTime;
    [SerializeField] bool canReciveDamage;
    private GameManager manager;
    #endregion

    #region Unity Methods

    private void Start()
    {
        manager = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
        canReciveDamage = true;
        health = maxHealth;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Laser"))
        {
            loseHealth();
        }
    }
    #endregion

    #region private methods
    private void CheckHealth()
    {
        if (health <= 0)
        {
            manager.GameOver();
            Destroy(gameObject);
        }
    }
    #endregion

    #region public methods
    public void loseHealth()
    {
        if (canReciveDamage && health >= 1)
        {
            health--;
            manager.loseHealth();
            StartCoroutine(Invulnerable());
        }
        CheckHealth();
    }

    public void RecoverHealth(int value)
    {
        health += value;
        if (health > maxHealth)
            health = maxHealth;
        manager.RecoverHealth();
    }

    public void RecoverFullHealth()
    {
        health = maxHealth;
        manager.RecoverFullHealth();
    }

    public int GetHealth()
    {
        return health;
    }

    #endregion

    #region enumerators
    IEnumerator Invulnerable()
    {
        canReciveDamage = false;
        yield return new WaitForSeconds(invulnerabilityTime);
        canReciveDamage = true;
    }
    #endregion
}
