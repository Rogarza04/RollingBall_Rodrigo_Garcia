using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;


public class ContadorMonedas : MonoBehaviour
{
    
    public int Cantidad = 0;
    
    [Header("TextUI")]
    public TextMeshProUGUI monedastxt;

    private void Update()
    {
        monedastxt.text = "Monedas: " + Cantidad.ToString();

        
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "laser")
        {

            Cantidad--;

            


        }

    }
}




