using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Class to show the control pattern
/// when you start the tutorial
/// Dominik Betzler
/// </summary>
public class SteuerungAnfang : MonoBehaviour
{
    /// <summary>
    /// gets the canvas
    /// </summary>
    public Canvas control;

	/// <summary>
    /// Sets timeScale to 0
    /// so nothing else can be
    /// triggerd
    /// </summary>
	void Start ()
    {
        Time.timeScale = 0;
        control.enabled = true;
	}
	
    /// <summary>
    /// method for the button
    /// to close the canvas
    /// </summary>
    public void BackToGame()
    {
        Time.timeScale = 1;
        control.enabled = false;
    }
	
}
