using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

/// <summary>
/// class for all buttons that load a scene
/// Dominik Betzler
/// </summary>
public class Levels : MonoBehaviour
{
    /// <summary>
    /// Class gets the canvas for the 
    /// mainMenu and levelsMenu
    /// </summary>
    public Canvas mainMenu;
    public Canvas levelsMenu;

    /// <summary>
    /// enables the mainMenu and
    /// disables the levelsMenu
    /// </summary>
    public void Back()
    {
        mainMenu.enabled = true;
        levelsMenu.enabled = false;
    }

    /// <summary>
    /// loads the scene Tutorial
    /// </summary>
    public void Tutorial()
    {
        SceneManager.LoadScene("Tutorial");
    }

    /// <summary>
    /// loads the scene Level1
    /// </summary>
    public void Level1()
    {
        SceneManager.LoadScene("Level1");
    }

    /// <summary>
    /// loads the scene Level2
    /// </summary>
    public void Level2()
    {
        SceneManager.LoadScene("Level2");
    }

    /// <summary>
    /// loads the scene Level3
    /// </summary>
    public void Level3()
    {
        SceneManager.LoadScene("Level3");
    }

    

}
