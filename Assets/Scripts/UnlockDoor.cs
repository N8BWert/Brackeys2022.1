using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockDoor : MonoBehaviour
{
    public GameObject transitionManager;
    private bool canPickUp;

    void Update() {
        if (canPickUp && Input.GetButtonDown("PlayerInteract")) {
            STransitInteractable.doorUnlocked = true;
            Destroy(this.gameObject);
        }
    }
    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")) {
            canPickUp = true;
        }
    }

    private void OnTriggerExit(Collider other) {
        if (other.CompareTag("Player")) {
            canPickUp = false;
        }
    }
}
