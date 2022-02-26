using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorInteraction : MonoBehaviour
{
    private Animator anim;
    private MeshCollider col;
    // Start is called before the first frame update
    void Start()
    {
        anim = this.gameObject.GetComponent<Animator>();
        col = this.gameObject.GetComponent<MeshCollider>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) {
            anim.SetBool("Open", true);
            col.enabled = false;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player")) {
            anim.SetBool("Open", false);
            col.enabled = true;
        }
    }
}
