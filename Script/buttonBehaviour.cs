using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Vehicles.Car;


public class buttonBehaviour : MonoBehaviour
{
    
   
    [SerializeField]
    private GameObject selection;


 

    int currentTrack;
    public void TrackSelect_track01()
    {
        currentTrack = 1;
    }
    public void PlayGame()
    {
        if (currentTrack == 1)
        {
            SceneManager.LoadScene("Track01");
        }

        else
        {
            selection.SetActive(true);
        }
    }

    public void back()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu");
    }

    public void restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Track01");
    }

    public void resume()
    {
        CarAudio.m_LowDecel.Play();
        CarAudio.m_LowAccel.Play();
        CarAudio.m_HighDecel.Play();
        CarAudio.m_HighAccel.Play();
        Time.timeScale = 1;
    }

    public void quit()
    {
        Application.Quit();
    }

}
