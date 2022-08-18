using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Number : MonoBehaviour
{
    int guess =5;
    int minValue=1;
    int maxValue=10;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Welcome to the Number Guessing Game");
        Debug.Log("The Number range is from " + minValue + " and " + maxValue);
        Debug.Log("Tell me if your number is higher or lower than " + guess + "?");
        Debug.Log("Press Up arrow = Higher, Press Down arrow = Lower, Press Enter = Correct");

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            minValue = guess;
            guess = (maxValue + minValue) / 2;
            Debug.Log("Is it higher or lower than: " + guess);
        }
        if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            maxValue = guess;
            guess = (maxValue + minValue) / 2;
            Debug.Log("Is it higher or lower than: " + guess);
        }
    }
}
