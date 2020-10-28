using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    Vector3 offset;
    void Start()
    {   //dif-ce between camera and player position.
        offset = transform.position - target.position;
    }

    void LateUpdate()
    {
        //before - camera was not always behind the player
       // Vector3 newPos = target.position +  offset;
        // transform.position = Vector3.Slerp(transform.position, newPos, SmoothFactor);
        // transform.position = target.transform.position + offset;
        // transform.rotation = target.rotation;

        //after
       // Source used: "Camera behind Player". Link: https://stackoverflow.com/a/47904587.
        // Vector3 offsetRotated = target.transform.forward * 10.0f;
        // transform.position = target.transform.position - offsetRotated;
        // transform.LookAt (target.transform.position);
        // transform.position = new Vector3 (transform.position.x, transform.position.y + 6, transform.position.z);
        
        //19.
        Vector3 newPos = target.transform.rotation * offset;
        transform.position = target.transform.position + newPos;
        transform.LookAt (target.transform.position);
    }
}
