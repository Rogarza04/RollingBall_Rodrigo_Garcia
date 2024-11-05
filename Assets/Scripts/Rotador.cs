using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotador : MonoBehaviour
{
    [SerializeField] private float fuerzaR = 20;
    [SerializeField] private Vector3 direccionR;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().AddTorque(direccionR * fuerzaR, ForceMode.VelocityChange);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    void FixedUpdate()
    {

        //transform.Rotate(new Vector3(0, 10, 0) * velocidad * Time.deltaTime);
    }
}
