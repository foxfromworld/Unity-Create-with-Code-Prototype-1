using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    /*
    public float speed = 20.0f;
    public float turnSpeed = 20.0f;
    public float horizontalInput;
    public float forwardInput;
    */
    // Private Variables
    private float speed = 20.0f;
    private float turnSpeed = 20.0f;
    private float horizontalInput;
    private float forwardInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // This is where we get player input
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        // Move the vehicle ahead
        //transform.Translate(0, 0, 1);
        //transform.Translate(Vector3.forward);
        //transform.Translate(Vector3.forward * Time.deltaTime * 20);
        //transform.Translate(Vector3.forward * Time.deltaTime * speed);
        //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed);
        // We move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
        // We turn the vehicle
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
