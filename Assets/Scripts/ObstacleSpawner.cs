using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject[] obstaclePrefabs;

    public float minSpawnInterval = 1f;
    public float maxSpawnInterval = 3f;
    private float spawnInterval;
    private float timer = 0f;

    public float minScale = 0.5f;
    public float maxScale = 1.5f;

    void Start()
    {
        SetRandomSpawnInterval();
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnInterval)
        {
            SpawnObstacle();
            timer = 0f;
            SetRandomSpawnInterval();
        }
    }

    void SpawnObstacle()
    {
        int index = Random.Range(0, obstaclePrefabs.Length);
        GameObject newObstacle = Instantiate(obstaclePrefabs[index], new Vector3(13, -3, 0), Quaternion.identity);

        // ランダムなスケールを設定
        float randomScale = Random.Range(minScale, maxScale);
        newObstacle.transform.localScale = new Vector3(randomScale, randomScale, randomScale);
    }

    void SetRandomSpawnInterval()
    {
        spawnInterval = Random.Range(minSpawnInterval, maxSpawnInterval);
    }
}
