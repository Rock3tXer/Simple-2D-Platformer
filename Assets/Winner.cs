using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Winner : MonoBehaviour
{
    //Winner menu buttons  
    public void MenuOpe(){
          SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
    }

    public void QuitIt(){
          Application.Quit();
    }
}
