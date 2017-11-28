using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMushroom : MonoBehaviour
{
    [SerializeField]
    GameObject[] mushroom;
    [SerializeField]
    Transform[] spawnmushroom;


    float spawntime;
	// Use this for initialization
	void Start ()
    {
        SpawnMushroomRandom();
    }
	
	// Update is called once per frame
	void Update ()
    {
        
    }
    void SpawnMushroomRandom()
    {
        // int mushroomindex = Random.Range(0, mushroom.Length);
        int spawnPointIndex = Random.Range(0, spawnmushroom.Length);
        // Instantiate(mushroom[mushroomindex], spawnmushroom[spawnPointIndex].position, spawnmushroom[0].rotation);
        spawntime = 0;
        for (int i = 0; i < spawnmushroom.Length; i++)
        {
            int mushroomindex = Random.Range(0, mushroom.Length);
            Instantiate(mushroom[mushroomindex], spawnmushroom[i].position, spawnmushroom[0].rotation);
            spawntime = 0;
        }


    }
}
