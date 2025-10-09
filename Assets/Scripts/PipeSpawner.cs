using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipePrefab;
    public float spawnRate = 2f;
    public float heightOffset = 2f;

    private float timer = 0f;
    
    public int counter;

    void Start()
    {
        SpawnPipe();
        counter = 0;
    }

    void Update()
    {
        
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            if (counter != 10)
            {
                SpawnPipe();
                counter++;
                timer = 0;
            }
            else
            {
                timer = 0;
                counter++;
            }

        }
    }

    void SpawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        
        Vector3 spawnPos = new Vector3(transform.position.x, 
            Random.Range(lowestPoint, highestPoint), 0);
        
        Instantiate(pipePrefab, spawnPos, Quaternion.identity);
    }
}