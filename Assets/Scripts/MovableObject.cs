using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovableObject : MonoBehaviour
{
    private GameObject grabObject;

    void Start() {
        grabObject = GameObject.FindGameObjectWithTag("GrabObject");
    }
    private void OnTriggerStay(Collider other) {
        if (other.CompareTag("Player") && Input.GetButton("PlayerInteract")) {
            Transform playerTransform = grabObject.transform;
            this.gameObject.transform.position = playerTransform.position;
        }
    }
}
