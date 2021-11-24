using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameButtonScriptPlayer2 : MonoBehaviour

{
    public EndGameButtonScriptPlayer1 EGBSP1;
    public bool isPlayer2Near = false;
    // Start is called before the first frame update
    void Start()
    {

    }


    void OnCollisionEnter(Collision col)
    {
        if (col.collider.tag == "Player")
        {
            Debug.Log("Player Is Near Button");
            isPlayer2Near = true;

        }
        if (EGBSP1.isPlayer1Near)
        {
            Application.Quit();
            Debug.Log("End Game");
        }


    }

    void OnCollisionExit(Collision col)
    {
        isPlayer2Near = false;
    }
     



}
