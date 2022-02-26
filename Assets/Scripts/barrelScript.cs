using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barrelScript : MonoBehaviour
{
    public float decreaseTimerBy;

    public float shakeDuration = 0.2f;
    public float shakeAmount = 0.05f;

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")) {
            DrugManager.currentTime += decreaseTimerBy;
            CameraShake.Shake(shakeDuration, shakeAmount);
        }
    }
}
