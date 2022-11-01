using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWaveMovement : MonoBehaviour
{
    float sinCenterY;

    private void Start()
    {
        sinCenterY = transform.position.y;
    }

    private void FixedUpdate()
    {
        Vector2 pos = transform.position;

        float sin = MathF.Sin(pos.x);
        pos.y = sinCenterY + sin;

        transform.position = pos;
    }
}
