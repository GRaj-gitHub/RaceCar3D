using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Racefinished : MonoBehaviour
{
    public GameObject finishCube; //camera

    public GameObject lapPanelDisp;  //disable the laptime just to show best

    public GameObject lapCountDisp;  //disable the laptime just to show best

    public GameObject raceFinished; // message popup

    public GameObject positionMsg;

    public static int position = 0;
    public int totalLaps;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player" || other.tag == "AI_Tag01")
        {
           if(LapComplete.lapCount == totalLaps)
            {

                position++;
            }
            

           
            if (other.tag == "Player")
            {
                Debug.Log("race finished!!");
                Debug.Log("position: " + position + "");
                finishCube.SetActive(true);
                lapPanelDisp.SetActive(false);
                lapCountDisp.SetActive(false);
                positionMsg.GetComponent<Text>().text = position + "";
                raceFinished.SetActive(true);

            }
        }
       
    }
}
