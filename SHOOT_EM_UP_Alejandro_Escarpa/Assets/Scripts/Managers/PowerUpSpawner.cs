using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSpawner : MonoBehaviour
{
    [SerializeField] private float delay;
    [SerializeField] private float posY;
    [SerializeField] private GameObject[] powerUps;

    private void Start()
    {
        StartCoroutine(IPowerUpSpawner());
    }

    IEnumerator IPowerUpSpawner()
    {
        while(true)
        {
            yield return new WaitForSeconds(delay);
            Instantiate(powerUps[randomNumber(0, powerUps.Length)], new Vector3(transform.position.x, randomNumber(-posY, posY), 0), Quaternion.identity, transform);
        }
    }

    private float randomNumber(float min, float max)
    {
        return Random.Range(min, max);
    }
    private int randomNumber(int min, int max)
    {
        return Random.Range(min, max);
    }
}
