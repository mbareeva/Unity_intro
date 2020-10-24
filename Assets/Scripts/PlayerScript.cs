using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {
    public float moveSpeed = 10;
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
        
         if (Input.GetKey(KeyCode.R))
         { 
            //12. + 13.
            Vector3 relativePos = transform.forward; //links oder rechts hinzufügen
            angle++;
            //14. 
            Quaternion rotation = Quaternion.LookRotation(relativePos, Vector3.up);
            transform.rotation = rotation * Quaternion.Euler(0, angle, 0);
         }     
    }
}