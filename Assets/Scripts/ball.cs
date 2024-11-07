using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ball : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float velocidad;
    //[SerializeField] float fuerza;
    //[SerializeField] float distanciaChequeoSuelo;
    bool isJump = false;
    [SerializeField] float jumpForce = 0.5f;
    bool isGrounded = false;

    float movimientoHorizontal;
    float movimientoVertical;

    public GameObject winPanel;

    [SerializeField] private AudioClip sonidolaser;
    [SerializeField] private AudioManager miManager;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //currentVelocidad = velocidad;
        //SaltoNormal();
        //EstaEnElSuelo();
    }
    void Update()
    {
        
        //condicionSalto();
        movimientoHorizontal = Input.GetAxis("Horizontal");
        movimientoVertical = Input.GetAxis("Vertical");
        isJump = Input.GetKeyDown(KeyCode.Space);
        if (isJump && isGrounded)
        {

            rb.AddForce(new Vector3(0, jumpForce, 0), ForceMode.Impulse);
        }
    }
    private void FixedUpdate() 
    {
        Vector3 movimiento = new Vector3(movimientoHorizontal, 0.0f, movimientoVertical);
        rb.AddForce(movimiento * velocidad);
        if (Physics.Raycast(transform.position, Vector3.down, 0.3f))
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
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




    //private void OnControllerColliderHit(ControllerColliderHit hit)
    //{
    //    switch(hit.gameObject.tag)
    //    {
    //        case "SpeedBoost":
    //            velocidad = 25f;
    //            break;
    //    }
    //}

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "SpeedBoost")
        {

            velocidad += 70f;


        }

        if (other.tag == "meta")
        {

            winPanel.SetActive(true);
            Time.timeScale = 0.1f;


        }

        if (other.tag == "laser")
        {
            miManager.ReproducirSonido(sonidolaser);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "SpeedBoost")
        {

            velocidad -= 70f;


        }
    }

  
}
