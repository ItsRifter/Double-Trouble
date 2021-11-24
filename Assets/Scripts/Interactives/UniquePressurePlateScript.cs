using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UniquePressurePlateScript : MonoBehaviour
{
    [SerializeField]
    GameObject door1ToClose;
    [SerializeField]
    GameObject door2ToClose;
    
    [SerializeField]
    GameObject door2ToOpen;

    int doorCloseAmount = 4;
    bool isObjectStillOnPlate = false;
    public bool isUniquePressurePlateOn;
    void OnTriggerEnter(Collider col)
    {
       
        
        if (isUniquePressurePlateOn == false)
        {
            // if (col.GetComponent<Collider>().tag == "Player" || col.GetComponent<Collider>().tag == "Placeable")
            //{
               
                door2ToOpen.transform.position += new Vector3(0, 0, doorCloseAmount);

                door1ToClose.transform.position -= new Vector3(0, 0, doorCloseAmount);
                door2ToClose.transform.position -= new Vector3(0, 0, doorCloseAmount);
            //}
        }

        isUniquePressurePlateOn = true;
    }

    void OnCollisionStay(Collision col)
    {
        isObjectStillOnPlate = true;
    }

    void OnCollisionExit(Collision col)
    {
        
        isObjectStillOnPlate = false;
    }

    void OnTriggerExit(Collider col)
    {
        if (isObjectStillOnPlate == false && isUniquePressurePlateOn == true)
        {
            Debug.Log("Move door");
            isUniquePressurePlateOn = false;

            
            door2ToOpen.transform.position -= new Vector3(0, 0, doorCloseAmount);

            door1ToClose.transform.position += new Vector3(0, 0, doorCloseAmount);
            door2ToClose.transform.position += new Vector3(0, 0, doorCloseAmount);

           
        }
    }
}
