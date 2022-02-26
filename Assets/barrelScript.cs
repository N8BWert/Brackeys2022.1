using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barrelScript : MonoBehaviour
{
    public GameObject DrugManager;
    public float decreaseTimerBy;

    public float shakeDuration = 0.2f;
    public float shakeAmount = 0.05f;

    void Awake() {
        DrugManager = GameObject.FindGameObjectWithTag("Manager");
    }

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")) {
            DrugManager.GetComponent<DrugManager>().currentTime -= decreaseTimerBy;
            CameraShake.Shake(shakeDuration, shakeAmount);
        }
    }
}
