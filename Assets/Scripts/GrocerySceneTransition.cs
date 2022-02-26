using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GrocerySceneTransition : MonoBehaviour
{
    public string nextScene;
    private static bool canAdvance = false;

    public static void CanAdvance() {
        canAdvance = true;
    }

    void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player") && canAdvance) {
            SceneManager.LoadScene(nextScene);
        }   
    }
}
