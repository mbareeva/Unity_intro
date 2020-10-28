using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {
    public float moveSpeed = 1.0f;
    public Transform target;
    private float angle;

    // Start is called before the first frame update
    void Start () {

    }

    // Update is called once per frame
    void Update () {
        //11.
        float moveHorizontal = Input.GetAxis ("Horizontal");
        float moveVertical = Input.GetAxis ("Vertical");
        transform.Translate (new Vector3 (moveHorizontal, 0, moveVertical) * moveSpeed * Time.deltaTime);
        //12. + 13. + 14.
        Vector3 relativePos = transform.forward;
        if (Input.GetKey (KeyCode.R)) {
            angle = 1.0f; 
            Quaternion rotation = Quaternion.LookRotation(relativePos, Vector3.up);
            transform.rotation = transform.rotation * Quaternion.Euler(0, +angle, 0);
        } 
        if (Input.GetKey (KeyCode.L)) {
            angle = 1.0f; 
            Quaternion rotation = Quaternion.LookRotation(relativePos, Vector3.up);
            transform.rotation =  transform.rotation * Quaternion.Euler(0, -angle, 0);
        }
    }
}