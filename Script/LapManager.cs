using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapManager : MonoBehaviour
{
    public static float millisecond;
    public static int minute;
    public static int second;
    public static string milliDisplay;

    public GameObject milliDisp;
    public GameObject minDisp;
    public GameObject secDisp;

    void Update()
    {
        millisecond += Time.deltaTime * 10;
        milliDisplay = millisecond.ToString("F0");
        milliDisp.GetComponent<Text>().text = milliDisplay + "";
        
        if (millisecond > 9)
        {
            millisecond = 0;
            second++;
        }

        if (second < 10) { secDisp.GetComponent<Text>().text = "0" + second + "" + "."; }
        
        else { secDisp.GetComponent<Text>().text = second + "" + "."; }

        if(second >= 60)
        {
            second = 0;
            minute++;
        }


        if (minute < 10) { minDisp.GetComponent<Text>().text = "0" + minute + "" + ":"; }

        else { minDisp.GetComponent<Text>().text = minute + "" + ":"; }

    }
}
