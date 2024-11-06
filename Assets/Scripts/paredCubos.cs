using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paredCubos : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Time.timeScale = 0.2f;
        }
    }
}
