using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class Ses : MonoBehaviour
{
 
    public AudioClip[] sesler;
   
   
    private void OnTriggerEnter2D(Collider2D nesne)
    {
        if (nesne.gameObject.tag == "altin")
        { GetComponent<AudioSource>().PlayOneShot(sesler[0]); Destroy(nesne.gameObject); }
        if (nesne.gameObject.tag == "black")
        { GetComponent<AudioSource>().PlayOneShot(sesler[1]); Destroy(nesne.gameObject); }
    }

    

}
    

