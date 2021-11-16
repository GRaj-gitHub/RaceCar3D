using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownManager : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource getReady;
    public AudioSource goAudio;

    public GameObject countText;
    public GameObject lapTimeController;
    public GameObject carController;
    void Start()
    {
        PlayerPrefs.SetInt("Best_min", 100);
        PlayerPrefs.SetInt("Best_sec", 100);
        StartCoroutine(countDown()); 
    }

    IEnumerator countDown()
    {
        yield return new WaitForSeconds(0.5f);
        countText.GetComponent<Text>().text = "3";
        getReady.Play();
        countText.SetActive(true);
        yield return new WaitForSeconds(1.0f);
        countText.SetActive(false);
        countText.GetComponent<Text>().text = "2";
        getReady.Play();
        countText.SetActive(true);
        yield return new WaitForSeconds(1.0f);
        countText.SetActive(false);
        countText.GetComponent<Text>().text = "1";
        getReady.Play();
        countText.SetActive(true);
        yield return new WaitForSeconds(1.0f);
        countText.SetActive(false);
        goAudio.Play();

        lapTimeController.SetActive(true);
        carController.SetActive(true);

    }
}
