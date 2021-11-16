using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class middle_checkpoint : MonoBehaviour
{
    [SerializeField]
    private GameObject last_check;
    [SerializeField]
    private GameObject middle_check;

    private void OnTriggerEnter(Collider player)
    {
        if(player.tag == "Player")
        {
            middle_check.SetActive(false);
            last_check.SetActive(true);
        }
       
    }
}
