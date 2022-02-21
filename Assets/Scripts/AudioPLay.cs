using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPLay : MonoBehaviour
{
    public AudioClip coin;
    public AudioClip wall;
    AudioSource audio;
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "coin")
        {
            audio.clip = coin;
            audio.Play();
        }
        if (other.gameObject.tag == "wall")
        {
            audio.clip = wall;
            audio.Play();
        }
    }
}
