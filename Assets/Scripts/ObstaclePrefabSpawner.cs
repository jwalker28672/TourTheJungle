using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstical : MonoBehaviour
{
    public GameObject[] obstaclePrefab;
    public GameObject   prefabSpawner;
    
    public  float spawnerDelay;
    private float delayTimer;

    // Start is called before the first frame update
    void Start()
    {
        delayTimer = spawnerDelay;

        spawnPrefabObstacle();
    }

    // Update is called once per frame
    void Update()
    {
        spawnPrefabObstacle();
    }


    


    private void spawnPrefabObstacle()
    {

        delayTimer += Time.deltaTime;


        if (delayTimer >= spawnerDelay)
        {
            int variation = Random.Range(0, obstaclePrefab.Length);
            GameObject spawnedPrefab = obstaclePrefab[variation];

            Instantiate(spawnedPrefab);
            spawnedPrefab.transform.position = new Vector2(prefabSpawner.transform.position.x, prefabSpawner.transform.position.y);

            delayTimer = 0f;
        }
    }
}
