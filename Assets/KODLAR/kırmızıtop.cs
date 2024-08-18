using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kırmızıtop : MonoBehaviour
{
    public Rigidbody2D rb;
    float jumpamount = 7f;
    // Start is called before the first frame update
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
