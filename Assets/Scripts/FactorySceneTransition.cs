using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FactorySceneTransition : MonoBehaviour
{
    public bool canEnter;
    public string nextScene;

    void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player") && canEnter) {
            SceneManager.LoadScene(nextScene);
        }
    }
}
