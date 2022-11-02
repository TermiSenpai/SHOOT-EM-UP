using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Vector3 direction;

    private void FixedUpdate()
    {
        transform.Translate(direction * Time.deltaTime * speed, Space.World);
    }
}
