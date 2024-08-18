using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport : MonoBehaviour
{
    
    public GameObject restart;
    public GameObject devam;
   
    public GameObject yardim;
    public GameObject yardim1;






    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "enemy")
        {

            Time.timeScale = 0;
            
            
            restart.SetActive(true);
          
           


        }
        if (col.gameObject.tag == "bayrak")
        {

            Time.timeScale = 0;


            devam.SetActive(true);
        



        }
        if (col.gameObject.tag == "su")
        {

          


            yardim.SetActive(true);
          



        }
        if (col.gameObject.tag == "black")
        {




            yardim1.SetActive(true);




        }
        

    }
}
