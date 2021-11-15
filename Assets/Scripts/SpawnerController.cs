using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour
{
    //Variables

    public GameObject[] carPrephab;

    // Start is called before the first frame update
    void Start()
    {
        
        InvokeRepeating("carSpawner", 2f, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void carSpawner()
    {
        int getRandomCar = Random.Range(0, carPrephab.Length);
        carPrephab[getRandomCar].transform.rotation = transform.rotation; 
        Instantiate(carPrephab[getRandomCar], transform.position, carPrephab[getRandomCar].transform.rotation);
    }
}
