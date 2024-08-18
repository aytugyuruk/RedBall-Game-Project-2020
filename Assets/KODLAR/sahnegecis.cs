using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sahnegecis : MonoBehaviour
{
    public GameObject algilama;

    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "bayrak3")
        {
            SceneManager.LoadScene("4.");
        }
        if (col.gameObject.tag == "bayrak1")
        {
            SceneManager.LoadScene("2.");
        }
        if (col.gameObject.tag == "bayrak2")
        {
            SceneManager.LoadScene("3.");
        }
        if (col.gameObject.tag == "bayrak4")
        {
            SceneManager.LoadScene("5.");
        }
        if (col.gameObject.tag == "bayrak5")
        {
            SceneManager.LoadScene("6.");
        }
        if (col.gameObject.tag == "bayrak6")
        {
            SceneManager.LoadScene("7.");
        }
        if (col.gameObject.tag == "bayrak7")
        {
            SceneManager.LoadScene("8.");
        }
        if (col.gameObject.tag == "bayrak8")
        {
            SceneManager.LoadScene("9.");
        }
        if (col.gameObject.tag == "bayrak9")
        {
            SceneManager.LoadScene("10.");
        }



    }

}
