using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapComplete : MonoBehaviour
{
    [SerializeField]
    private GameObject last_check;
    [SerializeField]
    private GameObject middle_check;

   

    public GameObject milliDisp;
    public GameObject minDisp;
    public GameObject secDisp;

   

    public GameObject RacefiinshTrigger;

    public GameObject lapCountDisp;  //disable the laptime just to show best

    
    [SerializeField]
    private int total_laps;

    public static int lapCount;

   
    
   
    private void OnTriggerEnter(Collider player)
    {
       
        if (player.tag == "Player")
        {
           

            if (LapManager.minute < PlayerPrefs.GetInt("Best_min"))
            {
                milliDisp.GetComponent<Text>().text = LapManager.milliDisplay + "";

                if (LapManager.second < 10) { secDisp.GetComponent<Text>().text = "0" + LapManager.second + "" + "."; }

                else { secDisp.GetComponent<Text>().text = LapManager.second + "" + "."; }

                if (LapManager.millisecond < 10) { minDisp.GetComponent<Text>().text = "0" + LapManager.minute + "" + "."; }

                else { minDisp.GetComponent<Text>().text = LapManager.minute + "" + "."; }
            }
            else if (LapManager.minute == PlayerPrefs.GetInt("Best_min"))
            {
                if(LapManager.second < PlayerPrefs.GetInt("Best_sec"))
                {
                    milliDisp.GetComponent<Text>().text = LapManager.milliDisplay + "";

                    if (LapManager.second < 10) { secDisp.GetComponent<Text>().text = "0" + LapManager.second + "" + "."; }

                    else { secDisp.GetComponent<Text>().text = LapManager.second + "" + "."; }

                    if (LapManager.millisecond < 10) { minDisp.GetComponent<Text>().text = "0" + LapManager.minute + "" + "."; }

                    else { minDisp.GetComponent<Text>().text = LapManager.minute + "" + "."; }
                }
            }


            PlayerPrefs.SetInt("Best_min", LapManager.minute);
            PlayerPrefs.SetInt("Best_sec", LapManager.second);

            LapManager.millisecond = 0;
            LapManager.second = 0;
            LapManager.minute = 0;

            lapCount++;
            lapCountDisp.GetComponent<Text>().text = lapCount + "";

            if (lapCount == total_laps)
            {
                
                RacefiinshTrigger.SetActive(true);
                
            }

            last_check.SetActive(false);
            middle_check.SetActive(true);

           
        }
       
    }

   
        
       
}
