using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpd = 1f;
    [SerializeField] float moveSpd = 0.01f;
    void Start()
    {
        
    }

    void Update()
    {
        float steerVal = Input.GetAxis("HAxis") * steerSpd;
        float moveVal = Input.GetAxis("VAxis") * moveSpd;
        // Object Rotation
        transform.Rotate(0,0,-steerVal);
        transform.Translate(0,moveVal,0);
    }
}
