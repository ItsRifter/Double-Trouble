using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportClass : MonoBehaviour
{
    public bool shouldTeleport;

    public float[3] position;

    private void OnCollisionEnter(Collision player)
    {
        if(player.gameObject.tag != "Player")
            return;

        if (shouldTeleport)
            player.gameObject.transform.position = new Vector3(position[0], position[1], position[2]);
    }

    public void toggleTeleporter()
    {
        shouldTeleport = !shouldTeleport;
    }
}
