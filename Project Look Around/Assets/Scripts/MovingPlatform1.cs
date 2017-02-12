using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Valerian Wolff
/// </summary>
public class MovingPlatform1 : MonoBehaviour
{

    public Transform movingPlatform;
    public Transform position1; // Fixed Point, used as Anker-point for Platform
    public Transform position2; // Fixed Point, used as Anker-point for Platform
    public Vector3 newPosition;
    public string currentState;
    public float smooth; 
    public float resetTime; //Time that is used till Method resets


    private void Start()
    {
        ChangeTarget(); // Calls ChangeTarget Method.
        
    }


    private void FixedUpdate()
    {
        // Moves the Platform between 2 positions
        movingPlatform.position = Vector3.Lerp(movingPlatform.position, newPosition, smooth * Time.deltaTime);

    }

    void ChangeTarget() //Methode that changes the position between pos. 1 and pos. 2.
    {
        if (currentState == "Moving to Position 1")
        {
            currentState = "Moving to Position 2";
            newPosition = position2.position;
        }
        else if (currentState == "Moving to Position 2")
        {
            currentState = "Moving to Position 1";
            newPosition = position1.position;
        }
        else if (currentState == "")
        {
            currentState = "Moving to Position 2";
            newPosition = position2.position;
        }
        Invoke("ChangeTarget", resetTime);
    }
}