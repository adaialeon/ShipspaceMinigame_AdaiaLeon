using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;

    public Transform spawnPosition;

    int ship = 1;

    [SerializeField] float timeRemaining = 3f;

    void Update()
    {
        if(timeRemaining <= 0)
        {
            timeRemaining = 3f;

            GameObject enemy = PoolManager.Instance.GetPooledObjects(ship, spawnPosition.position, spawnPosition.rotation);
            enemy.SetActive(true);
        }
        else
        {
            timeRemaining -= Time.deltaTime;
        }
    }
}
