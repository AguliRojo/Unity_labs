using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaneSwap : MonoBehaviour
{

    // Debug position
    private float nextActionTime = 1.0f;
    public float checkPosition = 2.0f;

    // Swapping action
    public float swappingLineDuration = 1.0f;
    public float swapLineCurrentDuration = 0.0f;
    
    void Update()
    {
        var Vehicle = GameObject.Find("Car");
        if (Time.time > nextActionTime ) {
            nextActionTime += checkPosition;
            Debug.Log(GameObject.Find("Car").transform.position);
        }
        if (swapLineCurrentDuration >= swappingLineDuration)
        {
            if(Input.GetKey("p"))
                {
                    Vector3 temp = new Vector3(5.0f,0,0);
                    Vehicle.transform.position += temp;
                    swapLineCurrentDuration = 0;
                } 
            if(Input.GetKey("o"))
                {
                    Vector3 temp = new Vector3(-5.0f,0,0);
                    Vehicle.transform.position += temp;
                    swapLineCurrentDuration = 0;
                } 
        }

        swapLineCurrentDuration += Time.deltaTime;
    }
}