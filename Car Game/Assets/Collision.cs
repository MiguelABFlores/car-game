using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("Car crashed!");
    }

    private void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("Car entered pink zone!");
    }
}
