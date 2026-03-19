// FlightController.cs
// CENG454 - HW1: Sky-High Prototype
// Author: Zeynep Aslan | Student ID: 210444028


using UnityEngine;

public class FlightController : MonoBehaviour
{
    public float pitchSpeed = 45f;
    public float yawSpeed = 60f;

    void Update()
    {
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");

        // Pitch (W/S)
        transform.Rotate(-vertical * pitchSpeed * Time.deltaTime, 0f, 0f);

        // Yaw (A/D)
        transform.Rotate(0f, horizontal * yawSpeed * Time.deltaTime, 0f);
    }
}