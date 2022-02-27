using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrugManager : MonoBehaviour
{
    public delegate void SwitchNextState(int stateNum);
    public static event SwitchNextState switchNextState;

    public float timeBetweenStates = 15f;
    public static float currentTime;

    public static int currentIndex = 0;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = 0;
    }

    void Awake() {
        DontDestroyOnLoad(this.gameObject);
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
            CameraShake.Shake(1, 0.1f, 5);
            currentTime = 0;
        }
    }
}
