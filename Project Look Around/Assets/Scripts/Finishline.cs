using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

/// <summary>
/// Class for the finish point
/// that checks if the thing 
/// he colides with is the player
/// Dominik Betzler
/// </summary>
public class Finishline : MonoBehaviour
{
    /// <summary>
    /// class gets the Canvas for winning
    /// </summary>
    public Canvas winMenu;

    /// <summary>
    /// if other has the tag Player he sets 
    /// timescale to 0 and enables the win menu
    /// </summary>
    /// <param name="other">the thing he colides with</param>
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Time.timeScale = 0;
            winMenu.enabled = true;
        }

        
    }
}
