using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Class for the buttons
/// in the scene MoreSoon
/// Dominik Betzler
/// </summary>
public class SceneMoreSoonButtons : MonoBehaviour
{
    /// <summary>
    /// loads the scene MainMenu
    /// </summary>
    public void BackToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
	
}
