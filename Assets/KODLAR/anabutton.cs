using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class anabutton : MonoBehaviour
{
    public void Sahnedegistir(int sahneid){

        SceneManager.LoadScene(sahneid);
        Time.timeScale = 1;

    }
}
