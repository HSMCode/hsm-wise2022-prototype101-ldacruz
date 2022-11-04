using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceRoll : MonoBehaviour
{
    public int diceNumber;
    // public float diceNumberFloat;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    { 

        if(Input.GetKeyDown("w"))
        {
            diceNumber = Random.Range(1, 7);
            Debug.Log("You rolled number: " + diceNumber);

            // diceNumberFloat = Random.Range(0f, 1f);
            // Debug.Log("You rolled float number: " + diceNumberFloat);
        }
        
    }
}
