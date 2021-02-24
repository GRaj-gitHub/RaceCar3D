using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControll : MonoBehaviour
{
    [SerializeField]
    private GameObject[] Camera = new GameObject[3];

    public static int cameraCount = 1;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.C))
        {
            StartCoroutine(cameraChange());
        }
        
    }

    IEnumerator cameraChange()
    {
        yield return new WaitForSeconds(0.05f);
        if (cameraCount == 0)
        {
            Camera[cameraCount].SetActive(true);
            Camera[2].SetActive(false);
            cameraCount++;

        }
        else if (cameraCount == 1)
        {
            Camera[cameraCount].SetActive(true);
            Camera[0].SetActive(false);
            cameraCount++;

        }
        else if (cameraCount == 2)
        {
            Camera[cameraCount].SetActive(true);
            Camera[1].SetActive(false);
            cameraCount = 0;

        }


    }
}
