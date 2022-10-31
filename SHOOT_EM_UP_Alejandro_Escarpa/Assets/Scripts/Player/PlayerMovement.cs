using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows.Speech;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [Space]
    [Header("Vector X limit")]
    [SerializeField] private float maxX;
    [SerializeField] private float minX;
    [Space]
    [Header("Vector Y limit")]
    [SerializeField] private float maxY;
    [SerializeField] private float minY;

    private float horizontal;
    private float vertical;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        rb.velocity = new Vector2(horizontal * speed, vertical * speed);

        transform.position = new Vector2(Mathf.Clamp(transform.position.x, minX, maxX), Mathf.Clamp(transform.position.y, minY, maxY));
    }

}
