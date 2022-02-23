using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorInteraction : MonoBehaviour
{
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = this.gameObject.GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) {
            anim.SetBool("Open", true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player")) {
            anim.SetBool("Open", false);
        }
    }
}
