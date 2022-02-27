using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndFactoryActivation : MonoBehaviour
{
    public GameObject endSceneObject;
    public Text sceneText;

    void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")) {
            endSceneObject.GetComponent<FactorySceneTransition>().canEnter = true;
            sceneText.text = "hmm...if she's not here she must have just left...\nMaybe I can catch her on the way down...";
        }
    }
}
