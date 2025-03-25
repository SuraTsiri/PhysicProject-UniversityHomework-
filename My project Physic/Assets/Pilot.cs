using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pilot : MonoBehaviour
{
    private Rigidbody rb;

    public float engineThrust = 50;
    public float liftBooster = 0.3f;
    public float drag = 0.03f;
    public float angularDrag = 0.03f;

    public float yawPower = 50f;
    public float pitchPower = 50f;
    public float rollPower = 20f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
                
    }

    void Update()
    {
        // Thrust/Engine
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(transform.forward * engineThrust);
            
        }
        // 2. Lift Force - Simulates how airplanes gain altitude
        Vector3 lift = Vector3.Project(rb.velocity, transform.forward);
        rb.AddForce(transform.up * lift.magnitude * liftBooster);

        // 3. Drag (Air Resistance) - Prevents infinite acceleration
        rb.velocity -= rb.velocity * drag;
        rb.angularVelocity -= rb.angularVelocity * angularDrag;

        //4.Controls - Pitch, Yaw, and Roll
        float yaw = Input.GetAxis("Horizontal") * yawPower;
        rb.AddTorque(transform.up * yaw);

        float pitch = Input.GetAxis("Vertical") * pitchPower;
        rb.AddTorque(-transform.right * pitch);

    }
}
