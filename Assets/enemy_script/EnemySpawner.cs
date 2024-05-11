using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemydPrefab;
    public float spawnRate = 2.0f; // Saniyede bir asteroid
    private float nextSpawnTime;

    void Update()
    {
        if (Time.time >= nextSpawnTime)
        {
            SpawnAsteroid();
            nextSpawnTime = Time.time + 1f / spawnRate;
        }
    }

    void SpawnAsteroid()
    {
        // Ekranýn dört kenarýndan birini rastgele seç
        Vector2 spawnPosition = Vector2.zero;
        switch (Random.Range(0, 4))
        {
            case 0: // Üst
                spawnPosition = new Vector2(Random.Range(0f, Screen.width), Screen.height);
                break;
            case 1: // Alt
                spawnPosition = new Vector2(Random.Range(0f, Screen.width), 0);
                break;
            case 2: // Sol
                spawnPosition = new Vector2(0, Random.Range(0f, Screen.height));
                break;
            case 3: // Sað
                spawnPosition = new Vector2(Screen.width, Random.Range(0f, Screen.height));
                break;
        }
        Instantiate(enemydPrefab, Camera.main.ScreenToWorldPoint(new Vector3(spawnPosition.x, spawnPosition.y, 10)), Quaternion.identity);
    }
}
