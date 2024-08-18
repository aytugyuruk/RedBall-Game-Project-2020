using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class butonsagsol : MonoBehaviour
{
    public Rigidbody2D rb;
    public bool saggidiyor, solgidiyor, zipla1;
    float jumpamount = 7f;
    float rightforce = 7f;

    public void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    
     void Update()
    {
        if (saggidiyor)
        {
            rb.velocity = Vector2.right * rightforce;
        }
        if (solgidiyor)
        {
            rb.velocity = Vector2.left * rightforce;
        }
        if (zipla1)
        {
            if (Mathf.Approximately(rb.velocity.y,0))
            {
                rb.AddForce(Vector3.up * jumpamount, ForceMode2D.Impulse);
            }
        }
    }

    
    public void sol()
    {
        solgidiyor = true;
    }
    public void solbirak()
    {
        solgidiyor = false;
        
    }
    public void sag()
    {
        saggidiyor = true;
    }
    public void sagbirak()
    {
        saggidiyor = false;
        
    }
    public void zipla()
    {
        zipla1 = true;

    }
    public void ziplabirak()
    {
        zipla1 = false;

    }

}
