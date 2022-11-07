using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Vector3 direction;
    [SerializeField] private float lifeTime;

    PlayerHealth playerHealth;
    EnemySpawner spawner;

    private void Start()
    {
        spawner = GameObject.FindGameObjectWithTag("EnemyParent").GetComponent<EnemySpawner>();
        try
        {
            playerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
        }
        catch
        {
            spawner.SetCanSpawnEnemies(false);
            Destroy(transform.parent.gameObject);
        }
        Destroy(transform.parent.gameObject, lifeTime);
    }

    private void FixedUpdate()
    {
        transform.Translate(direction * Time.deltaTime * speed, Space.World);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            playerHealth.loseHealth();
        }

        Destroy(gameObject);
    }

    private void OnDestroy()
    {

    }
}
