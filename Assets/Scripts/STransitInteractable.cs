using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class STransitInteractable : MonoBehaviour
{

    public string nextSceneName;
    private bool canTransition = false;
    public static bool doorUnlocked = false;

    void Update() {
        if (canTransition && Input.GetButtonDown("PlayerInteract") && doorUnlocked) {
            ObjectTransforms.storeTransforms();
            SceneManager.LoadScene(nextSceneName);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) {
            canTransition = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player")) {
            canTransition = false;
        }
    }
}
