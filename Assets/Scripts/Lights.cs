using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lights : MonoBehaviour

{
    public Material otherMaterial = null;

    private bool usingOther = false;
    private MeshRenderer meshRenderer = null;
    private Material originalMaterial = null;


    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        // Collect pick ups
        if (other.CompareTag("Player"))
        {
            Debug.Log("changeshould");
            meshRenderer = GetComponent<MeshRenderer>();
            originalMaterial = meshRenderer.material;
        }


    }

}
