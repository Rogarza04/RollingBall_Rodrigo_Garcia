using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    
    public GameObject infoPanel;

    public void Play(string nombre)
    {
        SceneManager.LoadScene(nombre);
    }
    public void Salir()
    {
       
        Application.Quit();
    }

    public void info()
    {
        infoPanel.SetActive(true);

       
    }

    public void infoSalir()
    {
        infoPanel.SetActive(false);
    }
}
