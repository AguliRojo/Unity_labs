using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelController : MonoBehaviour
{

    [SerializeField] WheelCollider frontRight;
    [SerializeField] WheelCollider frontLeft;
    [SerializeField] WheelCollider backRight;
    [SerializeField] WheelCollider backLeft;

    [SerializeField] Transform frontRightTransform;
    [SerializeField] Transform frontLeftTransform;
    [SerializeField] Transform backRightTransform;
    [SerializeField] Transform backLeftTransform;

    public float acceleration = 500f;
    public float brakingForce = 300f;
    public float maxTurnAngle = 15f;


    private float currentAcceleration = 0f;
    private float currentBrakeForce = 0f; 
    private float currentTurnAngle = 0f;

    private void FixedUpdate()
    {

        currentAcceleration = acceleration * Input.GetAxis("Vertical");

        if (Input.GetKey(KeyCode.Space))
            currentBrakeForce = brakingForce;
        else 
            currentBrakeForce = 0f;

        // 4x4
        frontRight.motorTorque = currentAcceleration;
        frontLeft.motorTorque = currentAcceleration;
        backRight.motorTorque = currentAcceleration;
        backLeft.motorTorque = currentAcceleration;

        frontRight.brakeTorque = currentBrakeForce;
        frontLeft.brakeTorque = currentBrakeForce;
        backRight.brakeTorque = currentBrakeForce;
        backLeft.brakeTorque = currentBrakeForce;

        // steering
        currentTurnAngle = maxTurnAngle * Input.GetAxis("Horizontal");
        frontRight.steerAngle = currentTurnAngle;
        frontLeft.steerAngle = currentTurnAngle;

        // Update wheel meshes.
        UpdateWheel(frontRight, frontRightTransform);
        UpdateWheel(frontLeft, frontLeftTransform);
        UpdateWheel(backRight, backRightTransform);
        UpdateWheel(backLeft, backLeftTransform);

    }
    void UpdateWheel(WheelCollider col, Transform trans)
    {

        Vector3 position;
        Quaternion rotation;
        col.GetWorldPose(out position, out rotation);
        
        trans.position = position;
        trans.rotation = rotation;

    }
}

