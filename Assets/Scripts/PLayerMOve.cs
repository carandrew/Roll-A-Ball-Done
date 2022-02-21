using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PLayerMOve : MonoBehaviour
{
    public float speed = 30f;
    public float maxSpeed = 5f;
    public Rigidbody rb;
    public GameObject mainCamera;
    private int count;
    public TextMeshProUGUI countText;
    public GameObject winTextObject;
    public GameObject SPAWN;



    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        SetCountText();

        count = 0;
        winTextObject.SetActive(false);
        
    }
    void FixedUpdate()
    {
        Vector3 fromCameraToMe = transform.position - mainCamera.transform.position;
        fromCameraToMe.y = 0; // First, zero out any vertical component, so the movement plane is always horizontal.
        fromCameraToMe.Normalize(); // Then, normalize the vector to length 1 so that we don't affect the player more strongly when the camera is at different distances.
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        //Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        // We can cheat a bit here - we had to flatten out the 'forward' vector from the camera to the player, but the camera is always horizontal left-right, so we can just use
        // its 'transform.right' vector to determine the direction to move the ball. Add the horizontal and vertical vectors to determine ground-plane movement.
        Vector3 movement = (fromCameraToMe * moveVertical + mainCamera.transform.right * moveHorizontal) * speed;


        rb.AddForce(movement * speed);
        if (rb.velocity.magnitude > maxSpeed)
        {

            rb.velocity = rb.velocity.normalized * maxSpeed;
        }



    }

    void OnTriggerEnter(Collider other)
    {
        // Collect pick ups
        if (other.CompareTag("Pick Up"))
        {
            count = count + 1;
            SetCountText();
            Debug.Log("Pick up collected!");
            other.gameObject.SetActive(false);
            


        }
    }

    void SetCountText()
    {
        countText.text = ": " + count.ToString() + "/7";

        if (count == 7)
        {
            // Set the text value of your 'winText'
            winTextObject.SetActive(true);
            rb.constraints = RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ |  RigidbodyConstraints.FreezePositionX;
            SPAWN.SetActive(false);
        }
    }

}