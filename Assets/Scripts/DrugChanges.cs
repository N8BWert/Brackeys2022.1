using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrugChanges : MonoBehaviour
{

    public Material[] mats = new Material[4];
    public Mesh[] meshes = new Mesh[4];

    private GameObject changeManager;
    // Start is called before the first frame update

    void Awake() {
        this.gameObject.GetComponent<MeshFilter>().mesh = meshes[DrugManager.currentIndex];
        this.gameObject.GetComponent<MeshRenderer>().material = mats[DrugManager.currentIndex];
    }

    private void OnEnable()
    {
        DrugManager.switchNextState += changeState;
        DaDrug.resetState += resetState;
    }

    private void OnDestory() {
        DrugManager.switchNextState -= changeState;
        DaDrug.resetState -= resetState;
    }

    private void OnDisable() {
        DrugManager.switchNextState -= changeState;
        DaDrug.resetState -= resetState;
    }

    public void changeState(int stateNum) {
        this.gameObject.GetComponent<MeshFilter>().mesh = meshes[stateNum];
        this.gameObject.GetComponent<MeshRenderer>().material = mats[stateNum];
    }

    public void resetState() {
        this.gameObject.GetComponent<MeshFilter>().mesh = meshes[0];
        this.gameObject.GetComponent<MeshRenderer>().material = mats[0];
    }
}
