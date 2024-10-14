using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float velocidad;
    [SerializeField] float fuerza;
    [SerializeField] float distanciaChequeoSuelo;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
        SaltoNormal();
        EstaEnElSuelo();
    }
    void Update()
    {
        condicionSalto();
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");

        Vector3 movimiento = new Vector3(movimientoHorizontal,0.0f, movimientoVertical);
        rb.AddForce(movimiento * velocidad);
    }

    private void condicionSalto()
    {
        if (Input.GetKey(KeyCode.Space) && EstaEnElSuelo())
        {
            SaltoNormal();
        }

    }

    private void SaltoNormal()
    {
        rb.AddForce(Vector3.up * fuerza, ForceMode.Impulse);

    }

    private bool EstaEnElSuelo()
    {
        return Physics.Raycast(transform.position, Vector3.down, distanciaChequeoSuelo);
    }

    
  
}
