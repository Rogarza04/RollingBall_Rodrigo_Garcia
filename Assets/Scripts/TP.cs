using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TP : MonoBehaviour
{
    //[SerializeField] Transform transfromTp;
    [SerializeField] GameObject player;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {

            player.transform.position = new Vector3(-0.5747576f, 34.91486f, 119.8261f);


        }
    }
}
