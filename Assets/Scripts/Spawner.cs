using System;
using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject sferaPrefab;
    [SerializeField] private float respawnTime = 2f;

    private float currentRespawnTime;

    private void Start()
    {
    }

    private void Update()
    {
        if (currentRespawnTime > 0)
        {
            currentRespawnTime -= Time.deltaTime;
        }
        else
        {
            SpawnSfere();
            currentRespawnTime = respawnTime;
        }
    }

    private void SpawnSfere()
    {
        GameObject a = Instantiate(sferaPrefab, transform.position, transform.rotation);
    }
}
