using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] public GameObject enemyPrefab;
    [SerializeField] public float spawnInterval = 2f;
    [SerializeField] public int maxEnemies = 10;
    [SerializeField] public float spawnRange = 2f;
    [SerializeField] public int multiply = 1;

    private float timer;

    void Update()
    {
        if (Time.time - timer > spawnInterval)
        {
            if (GameObject.FindGameObjectsWithTag("Enemy").Length < maxEnemies)
            {
                for (int i = 0; i < multiply; i++)
                {
                    float randomZ = Random.Range(transform.position.z - spawnRange, transform.position.z + spawnRange);
                    SpawnEnemy(new Vector3(transform.position.x, transform.position.y, randomZ));
                    timer = Time.time;
                }
            }
        }
    }

    void SpawnEnemy(Vector3 spawnPosition)
    {
        Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
    }
}
