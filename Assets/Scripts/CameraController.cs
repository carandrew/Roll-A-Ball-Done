using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraController : MonoBehaviour
{
    public GameObject player;
    public Transform playerPoint;
    private Vector3 offset;
    public float speed = 8.0f;
  
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.Mouse1))
        {

            float h = speed * Input.GetAxis("Mouse X");
           transform.Rotate(0, h, 0);

           
           



        }
    }
}


