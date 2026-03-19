// FlightController.cs
// CENG454 - HW1: Sky-High Prototype
// Author: Zeynep Aslan | Student ID: 210444028


using UnityEngine;

public class FlightController : MonoBehaviour
{
    public float forwardSpeed = 10f;
    public float pitchSpeed = 45f;
    public float yawSpeed = 60f;
    public float rollSpeed = 80f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        if (rb!= null)
        {
            rb.freezeRotation = true;
        }
    }



    void Update()
    {
        float pitchInput = 0f;
        float yawInput = 0f;

        float roll = 0f;
        if (Input.GetKey(KeyCode.Q))
            roll = 1f;
        if (Input.GetKey(KeyCode.E))
            roll = -1f;

        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(Vector3.forward * forwardSpeed *Time.deltaTime);
        }
        
        

        if (Input.GetKey(KeyCode.UpArrow))
            pitchInput = -1f;
        else if (Input.GetKey(KeyCode.DownArrow))
            pitchInput = 1f;

        transform.Rotate(Vector3.right * pitchInput * pitchSpeed * Time.deltaTime);


        if (Input.GetKey(KeyCode.LeftArrow))
            yawInput = -1f;
        else if (Input.GetKey(KeyCode.RightArrow))
            yawInput = 1f;

        transform.Rotate(Vector3.up * yawInput * yawSpeed * Time.deltaTime);


    

        // Roll (Q/E)
        transform.Rotate(0f, 0f, roll * rollSpeed * Time.deltaTime);
    }
}