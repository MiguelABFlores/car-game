using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage = false;
    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Package" && hasPackage == false){
            Debug.Log("Package picked up.");
            hasPackage = true;
        }

        if (other.tag == "Customer" && hasPackage){
            Debug.Log("Package delivered.");
            hasPackage = false;
        }
    }
}
