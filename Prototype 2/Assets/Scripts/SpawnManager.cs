using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// hecho por Jose Adolfo Martinez Olvera.

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20;   //spaw de annimales dentro del eje x
    private float spawnPosZ = 20;     //spaw de animales dentro del eje z
    private float startDealy = 2;       //indica los segundos que tarda en inicar el spaw
    private float spawnInterval = 1.5f; //variable que indica el tiempo que tarda en salir nuevamente los aniales 
    // Start is called before the first frame update
    void Start()
    {
        //invoca el metodo de spawramdomanimal 
        InvokeRepeating("SpawnRandomAnimal", startDealy, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }
        //es la parte encaragda de generar a los animales de forma aleatoria 
    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX),
            0, spawnPosZ);


            Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
       
    }
}
