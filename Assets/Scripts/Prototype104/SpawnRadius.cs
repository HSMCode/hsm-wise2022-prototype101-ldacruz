using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class SpawnRadius : MonoBehaviour
{
    // Array for enemy prefabs to randomly choose from
    [SerializeField] GameObject[] Enemies;
    [SerializeField] float enemySpawnBoundsRadius;

    // Counter for spawned enemies
    [SerializeField] int spawnedEnemies;

    // This repeat rate is only changeable before starting the scene, to change the repeat rate on runtime we need a different solution
    [SerializeField] float repeatRateOnStart = 2f;


    // Start is called before the first frame update
    void Start()
    {
        // With Invoke Repeating only the parameters generated inside the method can be controlled
        InvokeRepeating("SpawningEnemies", 3f, repeatRateOnStart);
    }

    private Vector3 GenerateSpawnPosition()
    {
        // Get radius from SphereCollider
        var collider = GetComponent<SphereCollider>();
        enemySpawnBoundsRadius = collider.radius;

        // Create a random enemy spawn position 
        Vector3 enemySpawnPos = new Vector3(Random.Range(-enemySpawnBoundsRadius, enemySpawnBoundsRadius), 0,
            Random.Range(-enemySpawnBoundsRadius, enemySpawnBoundsRadius));

        // Check if random position is inside the collider, if not update position to closest point available
        Vector3 enemySpawnPosClosest = collider.ClosestPoint(enemySpawnPos);

        // Debug Log to check coordinates
        Debug.Log("Random Pos: " + enemySpawnPos + "Closest Position to Collider : " + enemySpawnPosClosest);
            
        return enemySpawnPosClosest;
    }

    void SpawningEnemies()
    {

            // Get a random slot from the enemy prefab array
            int number = Random.Range(0, Enemies.Length);

            // Instantiate a clone from the prefab enemies at the previously generated position
            Instantiate(Enemies[number], GenerateSpawnPosition(), Enemies[number].transform.rotation);

            spawnedEnemies++;
    }
}
