using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class yönetici : MonoBehaviour
{

    public Button sv1_,sv2_, sv3_, sv4_, sv5_, sv6_, sv7_, sv8_, sv9_, sv10_;

    public static bool sv1, sv2, sv3, sv4, sv5, sv6, sv7, sv8, sv9, sv10;

    private void Start()
    {
        sv1 = true;
    }


    private void Update()
    {
        if (sv2 == true)
        {
            sv2_.interactable = true;
        }

        if (sv3 == true)
        {
            sv3_.interactable = true;
        }
        if (sv4 == true)
        {
            sv4_.interactable = true;
        }
        if (sv5 == true)
        {
            sv5_.interactable = true;
        }
        if (sv6 == true)
        {
            sv6_.interactable = true;
        }
        if (sv7 == true)
        {
            sv7_.interactable = true;
        }
        if (sv8 == true)
        {
            sv8_.interactable = true;
        }
        if (sv9 == true)
        {
            sv9_.interactable = true;
        }
    }
}
