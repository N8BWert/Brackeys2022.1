using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class STransitInteractable : MonoBehaviour
{

    public string nextSceneName;
    private bool canTransition = false;

    void main() {
        if (canTransition && Input.GetButtonDown("PlayerInteract")) {
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
