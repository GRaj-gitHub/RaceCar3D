using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSet : MonoBehaviour
{
    [SerializeField]
    private GameObject Car;

    public float cubeX;
    public float cubeY;
    public float cubeZ;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //updating the cube with the rotation of the car

        cubeX = Car.transform.eulerAngles.x;
        cubeY = Car.transform.eulerAngles.y;
        cubeZ = Car.transform.eulerAngles.z;

        transform.eulerAngles = new Vector3(cubeX - cubeX, cubeY, cubeZ - cubeZ);
        
    }
}
