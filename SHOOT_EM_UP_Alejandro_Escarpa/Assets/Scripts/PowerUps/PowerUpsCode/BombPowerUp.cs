using UnityEngine;

public class BombPowerUp : PowerUp
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        source.PlayOneShot(audioClip);
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");

        foreach (GameObject enemy in enemies)
        {
            EnemyMove enemyMove = enemy.GetComponent<EnemyMove>();
            if (enemyMove != null)
            {
                enemyMove.Fx(enemy.transform.position);
                Destroy(enemy);
            }
        }

        destroyPowerUp();
    }

    private void destroyPowerUp()
    {
        Destroy(gameObject);
    }
}
