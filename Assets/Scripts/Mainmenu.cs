﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainmenu : MonoBehaviour
{
    public void PlayGame () 
    {
         SceneManager.LoadScene("BG");
    }

    public void QuitGame () 
    {
        Debug.Log ("Quit");
        Application.Quit();
    }
}
