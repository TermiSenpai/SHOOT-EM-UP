using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FXPlayer : MonoBehaviour
{
    [SerializeField] Transform parent;

    public void InstantiateSpriteFx(GameObject fx, Vector2 position)
    {
        Instantiate(fx, position, Quaternion.identity, parent.transform);
    }
    public void InstantiateParticleFx(ParticleSystem fx, Vector2 position)
    {
        Instantiate(fx, position, Quaternion.identity, parent.transform);
    }
}
