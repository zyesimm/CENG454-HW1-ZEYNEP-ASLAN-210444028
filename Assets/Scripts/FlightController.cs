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
        HandleRotation();
        HandleThrust();
    }

    private void HandleRotation()
    {
        float pitchInput = 0f;
        float yawInput = 0f;
        float rollInput = 0f;

    }

    private void HandleThrust()
    {

    }



}