using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectTransforms : MonoBehaviour
{
    public static Vector3[] objectPositions;
    public static Quaternion[] objectRotations;
    public int sceneNum = 0;
    // Start is called before the first frame update
    void Start()
    {
        if (sceneNum != 0) {
            GameObject[] newObjects = GameObject.FindGameObjectsWithTag("Movable");
            for (int i = 0; i < objectPositions.Length; i++) {
                newObjects[i].transform.position = objectPositions[i];
                newObjects[i].transform.rotation = objectRotations[i];
            }
        }
    }

    public static void storeTransforms() {
        GameObject[] objects = GameObject.FindGameObjectsWithTag("Movable");
        objectPositions = new Vector3[objects.Length];
        objectRotations = new Quaternion[objects.Length];
        for (int i = 0; i < objects.Length; i++) {
            objectPositions[i] = objects[i].transform.position;
            objectRotations[i] = objects[i].transform.rotation;
        }
    }
}
