using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMove : MonoBehaviour
{
    [SerializeField] EnemyBossHp boosHP;

    [SerializeField] float maxXPos;
    [SerializeField] float speed;

    [SerializeField] private bool isInMaxXPos;

    private Transform target;

    private void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    private void Update()
    {
        if (transform.position.x == maxXPos)
        {
            isInMaxXPos = true;
        }
        else
        {
            isInMaxXPos = false;
        }
    }

    private void FixedUpdate()
    {
        if (transform.position.x >= maxXPos && !isInMaxXPos)
        {
            transform.Translate(Vector2.left * Time.fixedDeltaTime * speed, Space.World);
        }

        if (target != null)
        {
            if (target.position.y > transform.position.y)
            {
                transform.Translate(Vector2.up * Time.fixedDeltaTime * speed, Space.World);
            }
            if (target.position.y < transform.position.y)
            {
                transform.Translate(Vector2.down * Time.fixedDeltaTime * speed, Space.World);
            }
        }

    }
}
