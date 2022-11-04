using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roboter : MonoBehaviour
{
    public float step = 1f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // movement on the Z axis

        if(Input.GetKeyDown("w"))
        {
            // move roboter back
            transform.Translate(0,0,step);
        }

        if(Input.GetKeyDown("s"))
        {
            // move roboter forward
            transform.Translate(0,0,-step);
        }


        // movement on the X axis

        if(Input.GetKeyDown("d"))
        {
            // move roboter right
            transform.Translate(step,0,0);
        }

        if(Input.GetKeyDown("a"))
        {
            // move roboter left
            transform.Translate(-step,0,0);
        }


    }
}
