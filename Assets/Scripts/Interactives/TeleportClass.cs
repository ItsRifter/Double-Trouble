using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportClass : MonoBehaviour
{
    public Transform teleportToGoTo;
    public ScriptForKey key1;
    public ScriptForKey key2;
    public PickUpObject barrel;
    bool barrelTeleported;

    private void OnTriggerEnter(Collider col)
    {
        
        if (col.GetComponent<Collider>().tag == "Key")
        {
            key1.transform.position = new Vector3((teleportToGoTo.position.x) + 5, teleportToGoTo.position.y, teleportToGoTo.position.z);
            Debug.Log("Nice");
            key1.isPlayer1TeleportedItem = true;
        }

        if (col.GetComponent<Collider>().tag == "Key2")
        {
            key2.transform.position = new Vector3((teleportToGoTo.position.x) + 5, teleportToGoTo.position.y, teleportToGoTo.position.z);
            Debug.Log("Nice");
            key2.isPlayer2TeleportedItem = true;
        }

        if (col.GetComponent<Collider>().tag == "Placeable")
        {
            if (barrel.isBarrelTeleported == false)
            {
                barrel.transform.position = new Vector3((teleportToGoTo.position.x) + 5, teleportToGoTo.position.y, teleportToGoTo.position.z);
                Debug.Log("Nice");
                barrel.isBarrelTeleported = true;
            }
        }
    }

    
}
