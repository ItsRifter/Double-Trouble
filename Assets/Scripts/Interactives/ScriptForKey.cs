using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptForKey : MonoBehaviour
{
    public Transform itemDest;
    public Transform itemDest2;
    bool isPlayer1HoldingItem = false;
    bool isPlayer2HoldingItem = false;
    public DoorScript doorToUnlock;
    public bool isPlayer1TeleportedItem = false;
    public bool isPlayer2TeleportedItem = false;


    void OnTriggerEnter(Collider col)
    {
        if (col.GetComponent<Collider>().tag == "Player")
        {
            isPlayer1HoldingItem = true;
            Debug.Log("bruh");
        }

        if (col.GetComponent<Collider>().tag == "Player2")
        {
            isPlayer2HoldingItem = true;
        }

        if (isPlayer1HoldingItem == true)
        {
            GetComponent<Rigidbody>().useGravity = false;
            this.transform.position = itemDest.position;
            this.transform.parent = GameObject.Find("ItemZone").transform;
        }

        if (isPlayer2HoldingItem == true)
        {
            GetComponent<Rigidbody>().useGravity = false;
            this.transform.position = itemDest2.position;
            this.transform.parent = GameObject.Find("ItemZone2").transform;
        }

    }

    void Update()
    {
     

        if (Input.GetKeyDown(KeyCode.E))
        {
            if (isPlayer1HoldingItem == true)
            {
                this.transform.parent = null;
                GetComponent<Rigidbody>().useGravity = true;
                isPlayer1HoldingItem = false;
            }

        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (isPlayer2HoldingItem == true)
            {
                this.transform.parent = null;
                GetComponent<Rigidbody>().useGravity = true;
                isPlayer2HoldingItem = false;
            }

        }

        if (doorToUnlock.isDoorOpen == true)
        {
            Destroy(this.gameObject);
        }

        if (isPlayer1TeleportedItem == true)
        {
            this.transform.parent = null;
            GetComponent<Rigidbody>().useGravity = true;
            isPlayer1HoldingItem = false;
            isPlayer1TeleportedItem = false;
        }

        if (isPlayer2TeleportedItem == true)
        {
            this.transform.parent = null;
            GetComponent<Rigidbody>().useGravity = true;
            isPlayer2HoldingItem = false;
            isPlayer2TeleportedItem = false;
        }

    }


}
