using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MilkInteract : MonoBehaviour
{
    private bool pickupable = false;
    // Start is called before the first frame update
    void Start()
    {
        if (pickupable && Input.GetButtonDown("PlayerInteract")) {
            GrocerySceneTransition.CanAdvance();
            Destroy(this.gameObject);
        }
    }

    void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")) {
            pickupable = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player")) {
            pickupable = false;
        }
    }
}
