using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarControll : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject car;
    public GameObject AICar01;
    void Start()
    {
        
        car.GetComponent<MonoBehaviour>().enabled = true;
        AICar01.GetComponent<MonoBehaviour>().enabled = true;
    }

  }
