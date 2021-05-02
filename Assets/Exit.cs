using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Exit : MonoBehaviour
{
    public Button yourButton;
    public void ExitGame () 
    {
        SceneManager.LoadScene("Menu");
    }

    public void Start() {
        Button exit = yourButton.GetComponent<Button>();
        exit.onClick.AddListener(ExitGame);
    }

}
