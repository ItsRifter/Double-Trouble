using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlateScript : MonoBehaviour
{
    [SerializeField]
    GameObject door;

    
    public UniquePressurePlateScript uniquePressurePlate;

    
    bool isObjectStillOnPlate = false;


    void OnTriggerEnter(Collider col)
    {
        if (uniquePressurePlate.isUniquePressurePlateOn == false)
        {

            door.transform.position += new Vector3(0, 4, 0);
        }
        
    }

    void OnTriggerExit(Collider col)
    {
        if(uniquePressurePlate.isUniquePressurePlateOn == false)
        {

            door.transform.position -= new Vector3(0, 4, 0);
        }
    }
}
