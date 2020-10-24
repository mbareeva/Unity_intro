using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // Start is called before the first frame update
    //public Transform target;
    public Transform target;
    private Vector3 offset;

    //public bool lookAtPlayer = false;
    public float SmoothFactor = 0.5f;
    void Start()
    {   //dif-ce between camera and player position.
        //15.
        offset = transform.position - target.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //update of camera position
        //18. Addiere Offset-Vektor auf die Position des Spielers.
        Vector3 newPos = target.position +  offset;

        //calculate new position not directly for smooth camera movement
        //interpolate between current camera pos and new one
        //15.
        transform.position = Vector3.Slerp(transform.position, newPos, SmoothFactor);
        transform.position = target.transform.position + offset;
        //16. 
        transform.rotation = target.rotation;
        

    }
}
