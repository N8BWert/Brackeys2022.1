using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBarrels : MonoBehaviour
{
    public GameObject barrel;
    private int numBarrels = 0;
    public int maxBarrels = 5;
    public int waitTime = 2;
    public Transform spawnLocation;

    void Awake() {
        StartCoroutine(spawnBarrels());
    }

    private IEnumerator spawnBarrels() {
        while (numBarrels < maxBarrels) {
            Instantiate(barrel, spawnLocation.position, spawnLocation.rotation);
            numBarrels += 1;
            yield return new WaitForSeconds(waitTime);
        }
    }
}
