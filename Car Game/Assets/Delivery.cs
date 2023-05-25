using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] Color32 hasPackageColor = new Color32 (0,0,1,1);
    [SerializeField] Color32 noPackageColor = new Color32 (1,1,1,1);
    [SerializeField] float destroyDelay = 0.5f;
    bool hasPackage = false;
    SpriteRenderer spriteRenderer;

    void Start(){
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnTriggerEnter2D(Collider2D other) {
        //When picking up package change color and boolean value
        if (other.tag == "Package" && !hasPackage){
            Debug.Log("Package picked up.");
            hasPackage = true;
            Destroy(other.gameObject, destroyDelay);
            spriteRenderer.color = hasPackageColor;
        }

        //When delivering package change color and boolean value
        if (other.tag == "Customer" && hasPackage){
            Debug.Log("Package delivered.");
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
        }
    }
}
