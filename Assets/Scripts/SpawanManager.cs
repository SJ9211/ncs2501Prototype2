using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawanManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public GameObject panelGameOver;
    //public int animalIndex;

    private float spawnRangeX = 17.5f;
    private float spawnPosZ = 20.0f;
    private float startDelay = 2.0f;
    private float spawnInterval = 1.5f;
    void Start()
    {
        panelGameOver.SetActive(false);
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }


    void Update()
    {

    }

    private void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX),
                                                     0, spawnPosZ);
        Instantiate(animalPrefabs[animalIndex], spawnPos,
        animalPrefabs[animalIndex].transform.rotation);
    }

    public void DisplayGameOver()
    {
        panelGameOver.SetActive(false);
    }
}
