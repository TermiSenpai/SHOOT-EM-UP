using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBossHp : MonoBehaviour
{
    private EnemySpawner spawner;
    private FXPlayer fx;

    [SerializeField] private int HP;

    [Space]

    [SerializeField] private bool canGetDamage = true;
    [SerializeField] private float invulnerabilityTime;
    [SerializeField] private GameObject explosion;

    [Space]

    [SerializeField] SpriteRenderer shipSprite;

    [Space]

    [SerializeField] private int enemyFase;

    private void Start()
    {
        fx = FindObjectOfType<FXPlayer>();
        spawner = FindObjectOfType<EnemySpawner>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (canGetDamage)
        {
            HP--;
            StartCoroutine(invulnerability());
            StartCoroutine(ChangeColor());
            CheckHP();
        }
    }

    private IEnumerator invulnerability()
    {
        canGetDamage = false;
        yield return new WaitForSeconds(invulnerabilityTime);
        canGetDamage = true;
    }

    private IEnumerator ChangeColor()
    {
        shipSprite.color = Color.red;
        yield return new WaitForSeconds(invulnerabilityTime);
        shipSprite.color = Color.white;
    }

    private void CheckHP()
    {
        switch (HP)
        {
            case <= 0:
                BossDefeated();
                break;
            case <= 30:
                SetEnemyFase(3);
                break;
            case <= 60:
                SetEnemyFase(2);
                break;
            case <= 100:
                SetEnemyFase(1);
                break;
        }
    }

    private void BossDefeated()
    {
        fx.InstantiateSpriteFx(explosion, transform.position);
        spawner.enemiesCount--;
        Destroy(gameObject);

    }

    public void SetEnemyFase(int fase)
    {
        enemyFase = fase;
    }

    public int GetEnemyFase()
    {
        return enemyFase;
    }
}
