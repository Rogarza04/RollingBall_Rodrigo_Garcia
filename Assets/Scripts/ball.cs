using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float velocidad;
    //[SerializeField] float fuerza;
    //[SerializeField] float distanciaChequeoSuelo;
    bool isJump = false;
    [SerializeField] float jumpForce = 0.5f;
    bool isGrounded = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
        //SaltoNormal();
        //EstaEnElSuelo();
    }
    void Update()
    {
        Movimiento();
        //condicionSalto();
       
    }

    void Movimiento()
    {
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");

        Vector3 movimiento = new Vector3(movimientoHorizontal, 0.0f, movimientoVertical);
        rb.AddForce(movimiento * velocidad);



     

        if (Physics.Raycast(transform.position, Vector3.down , 0.2f))
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }
        isJump = Input.GetKeyDown(KeyCode.Space);
        if (isJump && isGrounded)
        {

            rb.AddForce(new Vector3(0, jumpForce, 0), ForceMode.Impulse);
        }
    }

//    private void condicionSalto()
//    {
//        if (Input.GetKey(KeyCode.N) && EstaEnElSuelo())
//        {
//            SaltoNormal();
//        }

//    }

//    private void SaltoNormal()
//    {
//        rb.AddForce(Vector3.up * fuerza, ForceMode.Impulse);

//    }

//    private bool EstaEnElSuelo()
//    {
//        return Physics.Raycast(transform.position, Vector3.down, distanciaChequeoSuelo);
//    }

    
  
}
