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

    public GameObject laptimeBox;

    public GameObject milliDisp;
    public GameObject minDisp;
    public GameObject secDisp;

    public GameObject lapCountDisp;
    [SerializeField]
    private int total_laps;

    int lapCount;


    private void Update()
    {
        if (lapCount == total_laps)
        {
            Debug.Log("race finished!!");
        }
    }
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

            last_check.SetActive(false);
            middle_check.SetActive(true);
        }
       
    }
}
