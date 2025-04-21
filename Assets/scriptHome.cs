using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scriptHome : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
      public void iniciar(){
        Time.timeScale = 1;
        SceneManager.LoadSceneAsync(1);
    }

    public void sair(){
        Application.Quit();
    }
}
