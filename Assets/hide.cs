using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hide : MonoBehaviour
{
    

    GameObject button;

    // Start is called before the first frame update
    void Start()
    {
        button.GetComponent<Renderer>().enabled = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //if (setButton)
        //{
        //    button.GetComponent<Renderer>().enabled = true;
        //}
    }
}
