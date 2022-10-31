using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLaserMovement : MonoBehaviour
{
    [SerializeField] Vector2 direction;
    [SerializeField] float speed;
    [SerializeField] float lifeTime;

    private void Start()
    {
        Destroy(gameObject, lifeTime);
    }

    private void Update()
    {
        transform.Translate(direction * Time.deltaTime * speed);
    }
}
