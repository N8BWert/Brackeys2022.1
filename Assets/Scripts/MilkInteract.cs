using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MilkInteract : MonoBehaviour
{
    [SerializeField]
    private bool pickupable = false;
    public Text objective;
    // Start is called before the first frame update
    void Update()
    {
        if (pickupable && Input.GetButtonDown("PlayerInteract")) {
            GrocerySceneTransition.CanAdvance();
            objective.text = "Got the milk...\nTime to head home...I think she's waiting for me...";
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
