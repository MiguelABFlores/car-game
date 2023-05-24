using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject thingToFollow;
    //Camera's position is the same as the car

    void LateUpdate() {
        transform.position =  thingToFollow.transform.position + new Vector3 (0,0,-10);
    }
}
