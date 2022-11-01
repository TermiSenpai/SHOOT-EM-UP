using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoveLeft : MonoBehaviour
{
    [SerializeField] private float speed;

    private void FixedUpdate()
    {
        transform.Translate(Vector3.left * Time.deltaTime * speed, Space.World) ;
    }
}
