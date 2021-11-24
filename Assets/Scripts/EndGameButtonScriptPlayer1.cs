using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameButtonScriptPlayer1 : MonoBehaviour
{
    public EndGameButtonScriptPlayer2 EGBSP2;
    public bool isPlayer1Near = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    void OnCollisionEnter(Collision col)
    {
        if (col.collider.tag == "Player")
        {
            Debug.Log("Player Is Near Button");
            isPlayer1Near = true;
        }
        if (EGBSP2.isPlayer2Near)
        {
            Application.Quit();
            Debug.Log("End Game");
        }
        


    }

    void OnCollisionExit(Collision col)
    {
            isPlayer1Near = false;   
    }

}



