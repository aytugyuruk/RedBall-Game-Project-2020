using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zıpzıp : MonoBehaviour
{
    public Rigidbody2D rb;
    float jumpamount = 7f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Mathf.Approximately(rb.velocity.y, 0))
        { rb.AddForce(Vector3.up * jumpamount, ForceMode2D.Impulse); }
    }
   
}
