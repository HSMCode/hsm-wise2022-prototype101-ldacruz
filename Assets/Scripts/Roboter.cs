using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roboter : MonoBehaviour
{
    public float stepBack = 1f;
    public float stepForward = -1f;
    public float stepRight = -1f;
    public float stepLeft = 1f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(stepRight,0,stepBack);


        // movement on the Z axis

        if(Input.GetKeyDown("w"))
        {
            // move roboter back
            transform.Translate(0,0,stepBack);
        }

        if(Input.GetKeyDown("s"))
        {
            // move roboter back
            transform.Translate(0,0,stepForward);
        }



        // movement on the X axis

        if(Input.GetKeyDown("d"))
        {
            // move roboter back
            transform.Translate(stepLeft,0,0);
        }

        if(Input.GetKeyDown("a"))
        {
            // move roboter back
            transform.Translate(stepRight,0,0);
        }


    }
}
