using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecogerColecionable : MonoBehaviour
{
    public ContadorMonedas contadormonedas;

    // Start is called before the first frame update
    void Start()
    {
        contadormonedas = GameObject.FindGameObjectWithTag("Player").GetComponent<ContadorMonedas>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {

            contadormonedas.Cantidad = contadormonedas.Cantidad + 1;

            Destroy(gameObject);

        }
    }
}
