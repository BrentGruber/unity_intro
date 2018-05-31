using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

    private int guess;
    private int max;
    private int min;

	// Use this for initialization
	void Start () {

        //Start the game
        StartGame();
	}

    //This will initialize all variables and give initial instructions
    void StartGame()
    {
        initialize();

        Debug.Log("Welcome to number wizard!");
        Debug.Log("Please pick a number, between " + min + " and " + max);
        Debug.Log("Is your number higher or lower than " + guess);
        Debug.Log("Press Up if higher, Press Down if lower, press enter if this is your number");
    }

    void initialize()
    {
        min = 1;
        max = 1000;
        guess = (min + max) / 2;
    }
	
	// Update is called once per frame
	void Update () {
        //Up key was pressed, so number is in upper half
		if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Your number is " + guess);
            Debug.Log("Choose another number");
            initialize();
            NextGuess();
        }

	}

    void NextGuess()
    {
        guess = (min + max) / 2;
        Debug.Log("Is your number " + guess + "?");
    }
}
