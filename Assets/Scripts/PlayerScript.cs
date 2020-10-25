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
            Quaternion rotation = Quaternion.LookRotation (relativePos, Vector3.up);
            transform.rotation = Quaternion.RotateTowards (transform.rotation, rotation, Time.deltaTime * moveSpeed);
            target.RotateAround (transform.position, Vector3.up, Time.deltaTime * 45);
        }
    }
}