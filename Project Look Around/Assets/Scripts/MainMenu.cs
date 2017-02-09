using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

/// <summary>
/// class with methods for the buttons
/// in the scene MainMenu
/// Dominik Betzler
/// </summary>
public class MainMenu : MonoBehaviour {

    /// <summary>
    /// gets the canvas mainMenu 
    /// and levelsMenu
    /// </summary>
    public Canvas mainMenu;
    public Canvas levelsMenu;

    /// <summary>
    /// starts with enabeling the mainMenu
    /// and disabeling the levelsMenu
    /// </summary>
	void Start ()
    {
        mainMenu.enabled = true;
        levelsMenu.enabled = false;
	}

    /// <summary>
    /// method disabeling the mainMenu
    /// and enabeling the levelsMenu
    /// </summary>
    public void Levels()
    {
        mainMenu.enabled = false;
        levelsMenu.enabled = true;
    }
	
    /// <summary>
    /// loads the scene Credits
    /// </summary>
    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }
	
    /// <summary>
    /// closes the application
    /// </summary>
    public void Quit()
    {
        Application.Quit();
    }

}
