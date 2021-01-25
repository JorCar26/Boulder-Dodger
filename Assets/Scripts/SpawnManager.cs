using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] boulderPrefabs;
    public float spawnRangeX = 20;
    public float spawnRangeY = 20;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomBoulderX", 1, 2.5f);    
        InvokeRepeating("SpawnRandomBoulderY", 0.5f, 2.5f);
    }

    void SpawnRandomBoulderX()
    {
        int boulderIndex = Random.Range(0,boulderPrefabs.Length);
        Vector2 spawnPosX = new Vector2(Random.Range(-spawnRangeX, spawnRangeX), 10);

        Instantiate(boulderPrefabs[boulderIndex],spawnPosX,boulderPrefabs[boulderIndex].transform.rotation);
    }
    void SpawnRandomBoulderY()
    {
        int boulderIndex = Random.Range(0,boulderPrefabs.Length);
        Vector2 spawnPosY = new Vector2(30,Random.Range(-spawnRangeY, spawnRangeY));
        Instantiate(boulderPrefabs[boulderIndex],spawnPosY,boulderPrefabs[boulderIndex].transform.rotation);
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("escape"))
        {
            Application.Quit();
        }
    }
}
