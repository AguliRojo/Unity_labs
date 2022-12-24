using UnityEngine;
// self belance/restart car
public class CarCrash : MonoBehaviour
{
    public Transform from;
    public Transform to;
    public float percentage = 0.01f;

    void Update()
    {
        transform.rotation = Quaternion.Slerp(from.rotation, to.rotation, percentage);
        // slerp 0.3 instatnly rotates car to base state
    }
}
