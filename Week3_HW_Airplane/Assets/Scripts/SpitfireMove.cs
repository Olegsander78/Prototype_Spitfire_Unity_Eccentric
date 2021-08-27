using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpitfireMove : MonoBehaviour
{
    public Rigidbody RB;
    public float ConstForceValue = 0.2f;
    public float ForceValue = 10f;
    public float TorqueForce;


    void FixedUpdate()
    {
        RB.AddForce(transform.forward * ConstForceValue, ForceMode.VelocityChange);

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            RB.AddForce(transform.forward * ForceValue, ForceMode.VelocityChange);
        }
        float horizontal = Input.GetAxis("Horizontal");
        RB.AddTorque(transform.right * TorqueForce * horizontal, ForceMode.VelocityChange);

    }
}
