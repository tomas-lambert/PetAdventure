using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarCrontroller : MonoBehaviour
{
    //Variables

    //Speed
    [SerializeField] private float carSpeed = 5f;


    //Time of Being
    [SerializeField] private float timeOfCar = 25f;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        CarDestroy();
    }

    //Methods ------------------------------->

    //Get Speed
    private float GetCarSpeed()
    {
        return carSpeed;
    }
    private void SetCarSpeed(float newCarSpeed)
    {
        carSpeed = newCarSpeed;
    }

    //Enemy Moves
    private void MoveCar(Vector3 direction)
    {
        transform.Translate(carSpeed * Time.deltaTime * direction);
    }

    //Enemy Destroy After Time

    private void CarDestroy()
    {
        timeOfCar -= Time.deltaTime;
        if (timeOfCar > 0)
        {
            MoveCar(Vector3.forward);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
