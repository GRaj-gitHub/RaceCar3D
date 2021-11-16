using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Vehicles.Car;


public class PauseManager : MonoBehaviour
{
    [SerializeField]
    private GameObject pauseMenu;

    

    void Update()
    {
        if(Input.GetKey(KeyCode.Escape))
        {
            CarAudio.m_LowDecel.Stop();
            CarAudio.m_LowAccel.Stop();
            CarAudio.m_HighDecel.Stop();
            CarAudio.m_HighAccel.Stop();
            pauseMenu.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
