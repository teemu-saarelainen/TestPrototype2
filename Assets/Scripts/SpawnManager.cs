using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] animalPrefabs;

    private float spawnXRange = 20.0f;
    private float spawnPosZ = 20.0f;

    void SpawnRandomAnimal()
    {

        int animalIndex = (int)Random.Range(0.0f, (animalPrefabs.Length - 0.0001f));
        // Debug.Log("Length: " + animalPrefabs.Length);
        float randX = Random.Range(-spawnXRange, spawnXRange);
        Instantiate(animalPrefabs[animalIndex], new Vector3(randX, 0, spawnPosZ), animalPrefabs[animalIndex].transform.rotation);

    }

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", 2.0f, 1.5f);
    }

 
    // Update is called once per frame
    void Update()
    {
        /*
        if (Input.GetKeyDown(KeyCode.S))
        {
            SpawnRandomAnimal();
        }
        */
    }
}
