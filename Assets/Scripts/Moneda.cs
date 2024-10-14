using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Moneda : MonoBehaviour
{
    public TextMeshProUGUI Monedas;
    public ContadorMonedas contadormonedas;

    void Start()
    {
        Monedas = GetComponent<TextMeshProUGUI>();

    }

    private void OnTriggerEnter(Collider other)
    {
        ContadorMonedas contadormonedas = other.GetComponent<ContadorMonedas>();
        if (other.tag == "Player")
        {

            contadormonedas.Cantidad = contadormonedas.Cantidad + 1;

            

            Monedas.text = contadormonedas.Cantidad.ToString("0");
            Destroy(gameObject);
            

        }
    }
}
