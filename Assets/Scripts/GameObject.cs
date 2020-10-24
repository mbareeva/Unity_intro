using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObject : MonoBehaviour
{
    
    public Transform myPrefab = null;
    public List<Transform> list = new List<Transform>();
    
    // Start is called before the first frame update
    void Start()
    {
      
        for(int i = 0; i <= 5; i++) 
        {
          Quaternion rotation = Quaternion.Euler(new Vector3(0, Random.Range(-20.0f, 90.0f), 0));
          list.Add(Instantiate(myPrefab, new Vector3(Random.Range(-20.0f, 40.0f), Random.Range(-20.0f, 40.0f), Random.Range(-20.0f, 40.0f)), rotation));
        }
        
    }

    // Update is called once per frame

    void Update()
    {
        
        
           foreach (Transform e in list) {
               e.transform.Rotate(new Vector3(0, 0, -1f), Space.World);
           }
            
        
     }

}
