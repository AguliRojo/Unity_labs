// using UnityEngine;

// public class SpeedometerController : MonoBehaviour
// {
//     private const float MAX_SPEED_ANGLE = -40;
//     private const float ZERO_SPEED_ANGLE = 220;
//     private Transform needleTransform;

//     private float sppedMax;
//     private float speed;

//     private void Awake()
//     {
//         needleTransform = needleTransform.Find("Needle");

//         speed = 0f;
//         speedMax = 200f;
//     }
//     private void Update()
//     {
//         speed += 30f+Time.deltaTime;
//         if (speed > sppedMax) speed = sppedMax;

//         needleTransform.eulerAngles = newVector3(0,0, GetSpeedRotation());
    
//     }
//     private float GetSpeedRotation()
//     {
//         float totalAngleSize = ZERO_SPEED_ANGLE - MAX_SPEED_ANGLE;

//         float speedNormalized = speed/speedMax;

//         return ZERO_SPEED_ANGLE - speedNormalized * totalAngleSize;
//     }
// }
