using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Private variables
    private float speed = 20.0f;
    private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float forwardInput;

    public Camera mainCamera;
    public Camera hoodCamera;
    public KeyCode switchKey;

    public string inputID;

    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        //This is where we get player input.
        horizontalInput = Input.GetAxis("Horizontal" + inputID);
        forwardInput = Input.GetAxis("Vertical" + inputID);

        //We move the vehicle forward.
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        //We move the vehicle turn.
        transform.Rotate(Vector3.up , turnSpeed * horizontalInput *  Time.deltaTime);

        if (Input.GetKeyDown(switchKey))
        {
            mainCamera.enabled = !mainCamera.enabled;
            hoodCamera.enabled = !hoodCamera.enabled;
        }


    }
}
