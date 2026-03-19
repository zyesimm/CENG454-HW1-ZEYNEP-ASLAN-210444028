// FlightController.cs
// CENG454 - HW1: Sky-High Prototype
// Author: Zeynep Aslan | Student ID: 210444028


using UnityEngine;

public class FlightController : MonoBehaviour
{
    public float pitchSpeed = 45f;

    void Update()
    {
        float vertical = Input.GetAxis("Vertical");
        transform.Rotate(-vertical * pitchSpeed * Time.deltaTime, 0f, 0f);
    }
}