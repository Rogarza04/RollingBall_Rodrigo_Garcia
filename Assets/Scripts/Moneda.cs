using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Moneda : MonoBehaviour
{
    
    public ContadorMonedas contadormonedas;

    void Start()
    {
        

    }
    private void Update()
    {
        if (contadormonedas.Cantidad < 0)
        {
            contadormonedas.Cantidad = 0;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
       
        if (other.tag == "Player")
        {

            contadormonedas.Cantidad++;

            Destroy(gameObject);
            

        }

    }
}
