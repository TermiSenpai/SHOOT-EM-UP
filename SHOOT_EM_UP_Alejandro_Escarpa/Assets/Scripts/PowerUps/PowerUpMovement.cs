using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Vector2 direction;

    private void FixedUpdate()
    {
        transform.Translate(direction * Time.fixedDeltaTime * speed); 
    }
}
