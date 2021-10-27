using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject _ennemyPrefab = null;
    private GameObject ennemyPrefab { get { return _ennemyPrefab; } }

    public float _spawnDelay = 0.5f;

    private float spawnDelay { get { return _spawnDelay; } }

    private void Spawn()
    {
        Vector3 spawnPosition = transform.position;
        spawnPosition.z += Random.Range(-3.0f, 3.0f);
        Instantiate(ennemyPrefab, spawnPosition, transform.rotation);
    }

    private void Start()
    {
        InvokeRepeating("Spawn", 0, spawnDelay);
    }

}
