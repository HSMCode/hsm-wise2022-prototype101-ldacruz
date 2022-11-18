using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceRoll : MonoBehaviour
{
    // initialize dice number as int
        public int diceNumber;
        // public int luckyNumber1 = 1;
        // public int luckyNumber2 = 3;
        // public int luckyNumber3 = 6;    

    // initialize dice number as float
        // public float diceNumberFloat;    

    // initialize array
        // public int[] luckyNumbers = new int[3];  // just initializes the array with 3 empty slots
        public int[] luckyNumbers = {1,3,6}; // fills the variables in the array slots

    // initialize array of game objects
        // public GameObject[] myGameObjectArray;


    // Start is called before the first frame update
    void Start()
    {
        // if only the length of an array is initialized, this way you can fill the array slots on start
            // luckyNumbers[0] = 1;
            // luckyNumbers[1] = 3;
            // luckyNumbers[2] = 6;
    }

    // Update is called once per frame
    void Update()
    { 

        if(Input.GetKeyDown("w"))
        {
            diceNumber = Random.Range(1, 7);
            // Debug.Log("You rolled number: " + diceNumber);

            // diceNumberFloat = Random.Range(0f, 1f);
            // Debug.Log("You rolled float number: " + diceNumberFloat);

            // check for all array slots if any of those variables match my rolled dice number
            for(int i = 0; i < luckyNumbers.Length; i++)
            {
                // check the amount of loops passing in the for loop
                    // Debug.Log("for each of i. count: " + i);

                // if the dice number equals the lucky number
                if(diceNumber == luckyNumbers[i])
                {
                    Debug.Log("Congratulations: " + diceNumber + " is your lucky number today!");
                }
                else if(i == (luckyNumbers.Length-1))
                {
                    Debug.Log("Sorry. No luck! You lost.");
                }
            }

            // alternative if statement using the array slots inside an or statement 
                // if(diceNumber == luckyNumbers[0] || diceNumber == luckyNumbers[1] || diceNumber == luckyNumbers[2])
                // {
                //     Debug.Log("Congratulations: " + diceNumber + " is your lucky number today!");
                // }
                // else
                // {
                //     Debug.Log("Sorry. No luck! You lost.");
                // }
        }
        
    }
}
