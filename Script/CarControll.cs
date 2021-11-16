using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Vehicles.Car;

public class CarControll : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject car;
    public GameObject AICar01;
    void Start()
    {
        
        car.GetComponent<CarController>().enabled = true;
        AICar01.GetComponent<CarController>().enabled = true;
    }

  }
