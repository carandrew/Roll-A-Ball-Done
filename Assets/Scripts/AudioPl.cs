using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPl : MonoBehaviour
{
    public AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            audio.Play();
            Debug.Log("player hit");
        }

    }
}