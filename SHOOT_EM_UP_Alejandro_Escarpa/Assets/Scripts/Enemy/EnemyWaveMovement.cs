using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWaveMovement : MonoBehaviour
{
    float sinCenterY;
    [SerializeField] private float amplitude;
    [SerializeField] private float frequency;

    [SerializeField] private bool inverted;

    private void Start()
    {
        sinCenterY = transform.position.y;
    }

    private void FixedUpdate()
    {
        Vector2 pos = transform.position;

        float sin = MathF.Sin(pos.x * frequency) * amplitude;

        if (inverted)
            sin *= -1;

        pos.y = sinCenterY + sin;

        transform.position = pos;
    }
}
