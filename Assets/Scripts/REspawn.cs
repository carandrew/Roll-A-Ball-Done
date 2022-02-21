using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class REspawn : MonoBehaviour
{
   
    [SerializeField] private Transform respawnPoint;
    public Rigidbody playerRB;
    public GameObject cam;

    public void OnTriggerEnter(Collider other)
    {
        playerRB.transform.position = respawnPoint.transform.position;
        

    }


}