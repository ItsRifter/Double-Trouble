using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClass : MonoBehaviour
{
    public enum activatorFilter
    {
        PlayerOne,
        PlayerTwo,
        Both
    }

    public activatorFilter personToActivate;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Renderer>().material.SetColor("_Color", Color.red);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Trigger");

        if (collision.gameObject.name == personToActivate.ToString() || personToActivate.ToString() == "Both")
            GetComponent<Renderer>().material.SetColor("_Color", Color.green);
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == personToActivate.ToString() || personToActivate.ToString() == "Both")
           GetComponent<Renderer>().material.SetColor("_Color", Color.red);
    }
}
