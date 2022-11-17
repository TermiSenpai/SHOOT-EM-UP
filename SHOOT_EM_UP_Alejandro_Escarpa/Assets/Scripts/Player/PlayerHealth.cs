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
    private SpriteRenderer spriteRenderer;
    #endregion

    #region Unity Methods

    private void Start()
    {
        spriteRenderer= GetComponent<SpriteRenderer>();
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
            manager.SetCanGetPoints(false);
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
            StartCoroutine(IChangeColor());
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
    IEnumerator Invulnerable(float time)
    {
        canReciveDamage = false;
        yield return new WaitForSeconds(time);
        canReciveDamage = true;
    }

    IEnumerator IChangeColor()
    {
        spriteRenderer.color = Color.red;
        yield return new WaitForSeconds(invulnerabilityTime);
        spriteRenderer.color = Color.white;
    }
    #endregion
}
