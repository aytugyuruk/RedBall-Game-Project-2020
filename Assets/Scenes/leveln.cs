using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class leveln : MonoBehaviour
{
    private string levelsunlocked;

    public void Pass()
    {
        int currentlevel = SceneManager.GetActiveScene().buildIndex;
        if (currentlevel >= PlayerPrefs.GetInt(levelsunlocked))
        {
            PlayerPrefs.SetInt("levelsunlocked", currentlevel + 1);
        }
        Debug.Log("LEVEL" + PlayerPrefs.GetInt(levelsunlocked) + "UNLOCKED");
    }
}
