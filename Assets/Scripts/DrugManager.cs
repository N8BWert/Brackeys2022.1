using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrugManager : MonoBehaviour
{
    public delegate void SwitchNextState();
    public static event SwitchNextState switchNextState;
    public delegate void ResetState();
    public static event ResetState resetState;

    public float timeBetweenStates = 15f;
    public float currentTime;
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
            switchNextState();
            currentTime = 0;
        }
        Debug.Log(currentTime);
    }
}
