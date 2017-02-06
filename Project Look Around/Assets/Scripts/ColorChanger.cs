using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ColorChanger : MonoBehaviour {
    public GameObject player;


	// Use this for initialization
	void Start ()
    {
        ColorWhite();
	}
	
	// Update is called once per frame
	void Update ()
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
        if (other.CompareTag("Red"))
        {
            ColorRed();
        }

        /// <summary>
        /// Appears when GameObject
        /// is blue
        /// </summary>
        if (other.CompareTag("Blue"))
        {
            ColorBlue();
        }

        /// <summary>
        /// Appears when GameObject
        /// is yellow
        /// </summary>
        if (other.CompareTag("Yellow"))
        {
            ColorYellow();
        }
    }


    /// <summary>
    /// changes colot to white
    /// </summary>
    private void ColorWhite()
    {
        player.GetComponent<Renderer>().material.color = Color.white;
    }

    /// <summary>
    /// changes colot to red
    /// </summary>
    private void ColorRed()
    {
        player.GetComponent<Renderer>().material.color = Color.red;
    }

    /// <summary>
    /// changes colot to blue
    /// </summary>
    private void ColorBlue()
    {
        player.GetComponent<Renderer>().material.color = Color.blue;
    }

    /// <summary>
    /// changes color to black
    /// </summary>
    private void ColorBlack()
    {
        player.GetComponent<Renderer>().material.color = Color.black;
    }

    /// <summary>
    /// changes color to yellow
    /// </summary>
    private void ColorYellow()
    {
        player.GetComponent<Renderer>().material.color = Color.yellow;
    }
}
