using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float upForce = 1000f;
    public float rightForce = 1000f;

    void FixedUpdate()
    {
        if(Input.GetKey("w"))
        {
            rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        }
        if(Input.GetKey("s"))
        {
            rb.AddForce(0, 0,-forwardForce * Time.deltaTime);
        }
        if(Input.GetKey("a"))
        {
            rb.AddForce(-rightForce * Time.deltaTime, 0,0);
        }
        if(Input.GetKey("d"))
        {
            rb.AddForce(rightForce * Time.deltaTime, 0,0);
        }
    }
}
