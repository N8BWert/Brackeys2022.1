using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LV3SceneTransition : MonoBehaviour
{
    public string nextScene;

    void OnTriggerEnter (Collider other) {
        if (other.CompareTag("Player")) {
            SceneManager.LoadScene(nextScene);
        }
    }
}
