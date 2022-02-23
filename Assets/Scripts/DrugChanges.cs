using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrugChanges : MonoBehaviour
{

    public Material[] mats = new Material[4];
    public Mesh[] meshes = new Mesh[4];

    private GameObject changeManager;
    private int currentIndex = 0;
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.GetComponent<MeshFilter>().mesh = meshes[0];
        this.gameObject.GetComponent<MeshRenderer>().material = mats[0];
        currentIndex = 0;
    }

    private void OnEnable()
    {
        DrugManager.switchNextState += changeState;
    }

    public void changeState() {
        currentIndex += 1;
        this.gameObject.GetComponent<MeshFilter>().mesh = meshes[currentIndex % meshes.Length];
        this.gameObject.GetComponent<MeshRenderer>().material = mats[currentIndex % mats.Length];
    }
}
