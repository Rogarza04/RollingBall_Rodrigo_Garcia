using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCamaraBola : MonoBehaviour
{
    [SerializeField] GameObject jugador;
    private Vector3 posicionRelativa;


    void Start()
    {
        posicionRelativa = transform.position - jugador.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = jugador.transform.position + posicionRelativa;
    }
}
