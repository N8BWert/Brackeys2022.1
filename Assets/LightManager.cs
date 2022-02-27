using System.Threading;
using System.Drawing;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightManager : MonoBehaviour
{
    public float timeBetweenStates = 15f;
    public float currentTime;
    
    public Light[] lights;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        if (currentTime >= timeBetweenStates) {
            foreach (Light l in lights)
            {
                l.color = UnityEngine.Color.Lerp(UnityEngine.Color.red, UnityEngine.Color.black, Time.deltaTime);
            }
            currentTime = 0;
        }
    }
}
