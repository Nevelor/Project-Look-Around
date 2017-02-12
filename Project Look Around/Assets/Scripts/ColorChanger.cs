using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Class for changing the color 
/// of the player
/// Dominik Betzler
/// </summary>
public class ColorChanger : MonoBehaviour
{
    /// <summary>
    /// class gets the GameObjects for player,
    /// leftArm and rightArm
    /// </summary>
    public GameObject player;
    public GameObject leftArm;
    public GameObject rightArm;


    /// <summary>
    /// it starts with calling the 
    /// ColorWhite method
    /// </summary>
    private void Start ()
    {
        ColorWhite();
	}

    /// <summary>
    /// calls the method ColorWhite 
    /// every time you press the q button
    /// </summary>
    private void Update ()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            ColorWhite();
        }
    }

    /// <summary>
    /// Appears when the player hits sth
    /// </summary>
    /// <param name="other">every other GameObject</param>
    private void OnTriggerEnter(Collider other)
    {
        /// <summary>
        /// Appears when GameObject
        /// is red
        /// </summary>
        if (other.CompareTag("RedCube"))
        {
            ColorRed();
            
        }

        /// <summary>
        /// Appears when GameObject
        /// is blue
        /// </summary>
        if (other.CompareTag("BlueCube"))
        {
            ColorBlue();
           
        }

        /// <summary>
        /// Appears when GameObject
        /// is yellow
        /// </summary>
        if (other.CompareTag("YellowCube"))
        {
            ColorYellow();
            
        }
    }


    /// <summary>
    /// changes color to white
    /// </summary>
    private void ColorWhite()
    {
        player.GetComponent<Renderer>().material.color = Color.white;
        leftArm.GetComponent<Renderer>().material.color = Color.white;
        rightArm.GetComponent<Renderer>().material.color = Color.white;
    }

    /// <summary>
    /// changes color to red
    /// </summary>
    private void ColorRed()
    {
        player.GetComponent<Renderer>().material.color = Color.red;
        leftArm.GetComponent<Renderer>().material.color = Color.red;
        rightArm.GetComponent<Renderer>().material.color = Color.red;
    }

    /// <summary>
    /// changes color to blue
    /// </summary>
    private void ColorBlue()
    {
        player.GetComponent<Renderer>().material.color = Color.blue;
        leftArm.GetComponent<Renderer>().material.color = Color.blue;
        rightArm.GetComponent<Renderer>().material.color = Color.blue;
    }

    /// <summary>
    /// changes color to black
    /// </summary>
    private void ColorBlack()
    {
        player.GetComponent<Renderer>().material.color = Color.black;
        leftArm.GetComponent<Renderer>().material.color = Color.black;
        rightArm.GetComponent<Renderer>().material.color = Color.black;
    }

    /// <summary>
    /// changes color to yellow
    /// </summary>
    private void ColorYellow()
    {
        player.GetComponent<Renderer>().material.color = Color.yellow;
        leftArm.GetComponent<Renderer>().material.color = Color.yellow;
        rightArm.GetComponent<Renderer>().material.color = Color.yellow;
    }
}
