using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public int hiz,deger;
    void Update()
    {
        gameObject.transform.Translate(new Vector3(deger * hiz * Time.deltaTime, 0, 0));
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag=="varilacak")
        {
            deger *= -1;
           
        }
    }
}
