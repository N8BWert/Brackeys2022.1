using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DaDrug : MonoBehaviour
{
    public Material[] mats;
    public delegate void ResetState();
    public static event ResetState resetState;

    private bool canPickUp;

    void Start() {
        this.gameObject.GetComponent<MeshRenderer>().material = mats[0];
    }

    void Update() {
        if (canPickUp && Input.GetButtonDown("PlayerInteract")) {
            resetState();
            DrugManager.currentIndex = 0;
            DrugManager.currentTime = 0.0f;
            Destroy(this.gameObject);
        }
    }

    private void OnEnable() {
        DrugManager.switchNextState += changeState;
        DaDrug.resetState += reset;
    }

    public void changeState(int stateNum) {
        if (this != null) {
            this.gameObject.GetComponent<MeshRenderer>().material = mats[stateNum];
        }
    }

    public void reset() {
        if (this != null) {
            this.gameObject.GetComponent<MeshRenderer>().material = mats[0];
        }
    }

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")) {
            canPickUp = true;
            Debug.Log("Pick Up");
        }
    }

    private void OnTriggerExit(Collider other) {
        if (other.CompareTag("Player")) {
            canPickUp = false;
            Debug.Log("Cannot pick up");
        }
    }
}
