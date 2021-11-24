using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public bool isDoorOpen = false;
   
    void OnTriggerEnter(Collider col)
    {
        if (col.GetComponent<Collider>().tag == "Key")
        {
            Debug.Log("Player Is Near door");
            isDoorOpen = true;
            transform.position = new Vector3(0,4,0);
            
            isDoorOpen = true;
        }

        if (col.GetComponent<Collider>().tag == "Key2")
        {
            Debug.Log("Player Is Near door");
            isDoorOpen = true;
            transform.position = new Vector3(0, 4, 0);
            
            isDoorOpen = true;
        }

    }
}
