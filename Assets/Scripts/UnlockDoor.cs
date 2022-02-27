using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnlockDoor : MonoBehaviour
{
    public GameObject transitionManager;
    private bool canPickUp;
    public Text objectiveText;
    public AudioSource audioOnPickup;

    void Update() {
        if (canPickUp && Input.GetButtonDown("PlayerInteract")) {
            STransitInteractable.doorUnlocked = true;
            objectiveText.text = "Alright...\nLet's head for the front door...";
            audioOnPickup.Play();
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
