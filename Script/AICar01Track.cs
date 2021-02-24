using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;
public class AICar01Track : MonoBehaviour
{
    public GameObject tracker;
    public GameObject[] marks = new GameObject[11];
    int markNumber;
    void Update()
    {
        for(int i =0; i < 11; i++)
        {
            if(markNumber == i)
            {
                tracker.transform.position = marks[i].transform.position;
            }
        }

        
    }

    IEnumerator OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag == "AI_Tag01")
        {
            this.GetComponent<BoxCollider>().enabled = false;
            markNumber++;
            if(markNumber == 11)
            {
                markNumber = 0;
            }
            yield return new WaitForSeconds(2.0f);
            this.GetComponent<BoxCollider>().enabled = true;
        }
    }
}
