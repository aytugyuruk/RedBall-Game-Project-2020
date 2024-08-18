using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level : MonoBehaviour
{
    int levelsunlocked;
    void Start()
    {
        levelsunlocked = PlayerPrefs.GetInt("levelsunlocked",1);
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
