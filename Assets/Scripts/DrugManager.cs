using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrugManager : MonoBehaviour
{
    public delegate void SwitchNextState(int stateNum);
    public static event SwitchNextState switchNextState;
    public delegate void ResetState();
    public static event ResetState resetState;

    public float timeBetweenStates = 15f;
    public float currentTime;

    public static int currentIndex = 0;
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
            if (currentIndex < 3) {
                currentIndex += 1;
            }
            switchNextState(currentIndex);
            currentTime = 0;
        }
        Debug.Log(currentTime);
    }
}
