using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpd = 0;
    [SerializeField] float moveSpd = 0;
    void Start()
    {
        
    }

    void Update()
    {
        float steerVal = Input.GetAxis("HAxis");
        float moveVal = Input.GetAxis("VAxis");
        // Object Rotation
        transform.Rotate(0,0,steerSpd);
        transform.Translate(0,moveSpd,0);
    }
}
