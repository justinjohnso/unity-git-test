using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int max;
    int min;
    int guess;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Welcome to the NUMBAR WIIIIZARD");
        StartGame();
    }

    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;
        
        Debug.Log("Think of a number from " + max + " to " + min);

        Debug.Log("Got it? Ok, is your number higher or lower than " + guess + "?");
        Debug.Log("↑ = Higher, ↓ = Lower, Return = Correct!"); 
    }

    // Update is called once per frame
    void Update()
    {
        //Detect when the Up arrow key is pressed down
        if (Input.GetKeyDown(KeyCode.UpArrow)){
            min = guess;
            NextGuess();
        }

        //Detect when the Down arrow key is pressed down
        else if (Input.GetKeyDown(KeyCode.DownArrow)){
            max = guess;
            NextGuess();
        }

        //Detect when the Return key is pressed down
        else if (Input.GetKeyDown(KeyCode.Return)){
            Debug.Log("Awww yeah, I can read your mind!");
            Debug.Log("Press ESC to play again");
        }

        else if (Input.GetKeyDown(KeyCode.Escape)){
            StartGame();
        }
    }

    void NextGuess()
    {
        guess = (max + min) / 2;
        if (max == min){
            Debug.Log("It has to be " + guess + "!");
        }
        else {
            Debug.Log("Is it higher or lower than " + guess + "?");
        }

    }
}
