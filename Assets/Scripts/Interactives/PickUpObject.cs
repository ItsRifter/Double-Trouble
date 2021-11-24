using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpObject : MonoBehaviour
{
    public Transform itemDest;
    bool isPlayerHoldingItem = false;
   

    void OnTriggerEnter(Collider col)
    {
        if (col.GetComponent<Collider>().tag == "Player")
        {
            isPlayerHoldingItem = true;
        }
    }

    void Update()
    {
        if (isPlayerHoldingItem == true)
        {
            GetComponent<Rigidbody>().useGravity = false;
            this.transform.position = itemDest.position;
            this.transform.parent = GameObject.Find("ItemZone").transform;
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            this.transform.parent = null;
            GetComponent<Rigidbody>().useGravity = true;
            isPlayerHoldingItem = false;
        }

    }
   
}
