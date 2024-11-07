using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuWin : MonoBehaviour
{
    
    
    public void MenuInicial()
    {
        SceneManager.LoadScene("Menu");
    }

    
    public void Salir()
    {
        
        Application.Quit();
    }
}
