// FlightController.cs
// CENG454 - HW1: Sky-High Prototype
// Author: Zeynep Aslan | Student ID: 210444028


using UnityEngine;

public class FlightController : MonoBehaviour
{
    public float pitchSpeed = 45f;
    public float yawSpeed = 60f;

    public float rollSpeed = 80f;


    void Update()
    {
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");

        float roll = 0f;
        if (Input.GetKey(KeyCode.Q))
            roll = 1f;
        if (Input.GetKey(KeyCode.E))
            roll = -1f;


        // Pitch (W/S)
        transform.Rotate(-vertical * pitchSpeed * Time.deltaTime, 0f, 0f);

        // Yaw (A/D)
        transform.Rotate(0f, horizontal * yawSpeed * Time.deltaTime, 0f);

        // Roll (Q/E)
        transform.Rotate(0f, 0f, roll * rollSpeed * Time.deltaTime);
    }
}