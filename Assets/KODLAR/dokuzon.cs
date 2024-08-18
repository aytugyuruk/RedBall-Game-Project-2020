using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class dokuzon : MonoBehaviour
{
    public GameObject algilama;

    // Update is called once per frame
    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "bayrak11")
        {
            SceneManager.LoadScene("10.");
        }
        if (col.gameObject.tag == "bayrak111")
        {
            SceneManager.LoadScene("11.");
        }
        

    }
}
