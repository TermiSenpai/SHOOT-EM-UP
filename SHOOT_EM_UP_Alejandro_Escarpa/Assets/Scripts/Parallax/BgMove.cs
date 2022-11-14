using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgMove : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] Vector2 direction;

    [SerializeField] Vector2 maxPos;
    [SerializeField] Vector2 newPos;


    private void Update()
    {
        if(transform.position.x <= maxPos.x)
        {
            transform.position = newPos;
        }
    }

    private void FixedUpdate()
    {
        transform.Translate(direction * Time.fixedDeltaTime * speed);
    }
}
