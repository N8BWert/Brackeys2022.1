using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndFactoryActivation : MonoBehaviour
{
    public GameObject endSceneObject;

    void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")) {
            endSceneObject.GetComponent<FactorySceneTransition>().canEnter = true;
        }
    }
}
