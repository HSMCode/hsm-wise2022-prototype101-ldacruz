using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableTests : MonoBehaviour
{
    public int numberOne = 1; 
    public int numberTwo = 2;
    public int result;

    // declare a float variable
    public float myFloat = 10f;

    // declare a string variable
    public string mySentence = "Mein schönster Satz in Unity";

    // Start is called before the first frame update
    void Start()
    {

      //result = numberOne + numberTwo;
      //Debug.Log("Das Resultat: " + result);

      // print float + string with debug.log
      Debug.Log(mySentence + " " + myFloat);

      Debug.LogFormat("My more easy to read log, with my Float {0}. my cool integer result variable {1} and a random sentence: {2}.", myFloat,result,mySentence);
        
    }

    // Update is called once per frame
    void Update()
    {

        // result += 1;
        // Debug.Log("Das Resultat im Update: " + result);

    }
}
