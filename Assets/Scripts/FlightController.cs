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


    void Update()
    {
        float pitchInput = 0f;
        float horizontal = Input.GetAxis("Horizontal");

        float roll = 0f;
        if (Input.GetKey(KeyCode.Q))
            roll = 1f;
        if (Input.GetKey(KeyCode.E))
            roll = -1f;


        //Forward Movement
        transform.position += transform.forward * forwardSpeed * Time.deltaTime;

        if (Input.GetKey(KeyCode.UpArrow))
            pitchInput = -1f;
        else if (Input.GetKey(KeyCode.DownArrow))
            pitchInput = 1f;

        transform.Rotate(Vector3.right * pitchInput * pitchSpeed * Time.deltaTime);




        // Yaw (A/D)
        transform.Rotate(0f, horizontal * yawSpeed * Time.deltaTime, 0f);

        // Roll (Q/E)
        transform.Rotate(0f, 0f, roll * rollSpeed * Time.deltaTime);
    }
}