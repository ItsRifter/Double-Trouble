using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpObject : MonoBehaviour
{
    public Transform itemDest;
    public Transform itemDest2;
    bool isPlayer1HoldingItem = false;
    bool isPlayer2HoldingItem = false;
    public bool isBarrelTeleported = false;


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

        if (isBarrelTeleported == true)
        {
            this.transform.parent = null;
            GetComponent<Rigidbody>().useGravity = true;
            isPlayer1HoldingItem = false;
            isBarrelTeleported = false;
        }


    }

}
