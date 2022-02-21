using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forward : MonoBehaviour
{
    public float jumpforce;
    public Rigidbody playerRB;
    public GameObject Score;
    public AudioSource GameMusic;
    public AudioSource Spring;
    public GameObject Extend;


    IEnumerator OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))

        {

            playerRB.AddForce(other.transform.forward * jumpforce, ForceMode.Impulse);

            Debug.Log("player entered jumpade trigger");
            
            playerRB.AddForce(other.transform.forward * jumpforce, ForceMode.Impulse);

            playerRB.GetComponent<PLayerMOve>().enabled = true;
            Score.SetActive(true);
            Spring.Play();
            yield return new WaitForSeconds(.5f);
            GameMusic.Play();
            yield return new WaitForSeconds(3f);
            Extend.SetActive(true);




        }
    }

}