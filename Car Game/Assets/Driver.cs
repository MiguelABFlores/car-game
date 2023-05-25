using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpd = 150f;
    [SerializeField] float moveSpd = 15f;
    [SerializeField] float slowSpeed = 7f;
    [SerializeField] float boostSpeed = 20f;

    void Update()
    {
        float steerVal = -Input.GetAxis("HAxis") * steerSpd * Time.deltaTime;
        float moveVal = Input.GetAxis("VAxis") * moveSpd * Time.deltaTime;
        transform.Rotate(0,0,steerVal);
        transform.Translate(0,moveVal,0);
    }

    //When colliding reduce movement speed
    void OnCollisionEnter2D(Collision2D other) {
        moveSpd = slowSpeed;
    }

    //When picking booster increase movement speed
    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Powerup"){
            moveSpd = boostSpeed;
        }
    }
}
