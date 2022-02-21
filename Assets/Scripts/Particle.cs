using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particle : MonoBehaviour
{

    public ParticleSystem hit;
    public AudioSource Audio;

    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        hit.Play();
        Audio.Play();
    }



}

