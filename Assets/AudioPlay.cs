using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlay : MonoBehaviour
{

    public AudioSource asource;
    // Start is called before the first frame update
    void Start()
    {
        asource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
