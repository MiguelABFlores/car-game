using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("Car crashed!");
    }

    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Residence"){
            Debug.Log("Car entered residence zone!");
        }
    }

    void OnTriggerExit2D(Collider2D other) {
        if(other.tag == "Residence"){
            Debug.Log("Car is exiting residence zone!");
        }
    }
}
