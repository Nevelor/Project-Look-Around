using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

/// <summary>
/// Manages all Canvas activities
/// and scenes that are loaded in a level
/// Dominik Betzler
/// </summary>
public class MainControllerScript : MonoBehaviour
{
    /// <summary>
    /// gets different Canvas
    /// in the Editor
    /// </summary>
    public Canvas pauseMenu;
    public Canvas tutorialMenu;
    public Canvas levelWin;
    public Canvas levelLose;

    public Canvas steuerungTutorial;
    public Canvas goalOfTheGame;
    public Canvas farbenTutorial;

    /// <summary>
    /// Starts with calling
    /// the method StartThings
    /// </summary>
    private void Start()
    {
        StartThings();
    }

    /// <summary>
    /// calls every frame the
    /// method EnablePauseMenu
    /// </summary>
    private void Update()
    {
        EnablePauseMenu();
    }

    
    /// <summary>
    /// all things that should be done when the game starts
    /// getting the Canvas componets and disables all canvas
    /// </summary>
    private void StartThings()
    {
       
        pauseMenu = pauseMenu.GetComponent<Canvas>();
        tutorialMenu = tutorialMenu.GetComponent<Canvas>();
        pauseMenu.enabled = false;
        tutorialMenu.enabled = false;

        levelWin = levelWin.GetComponent<Canvas>();
        levelLose = levelLose.GetComponent<Canvas>();
        levelWin.enabled = false;
        levelLose.enabled = false;

        steuerungTutorial.enabled = false;
        goalOfTheGame.enabled = false;
        farbenTutorial.enabled = false;
    }

   
    /// <summary>
    /// by pressing the Escape key
    /// the pauseMenu gets dis or enabled
    /// </summary>
    private void EnablePauseMenu()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pauseMenu.enabled == false)
            {
                pauseMenu.enabled = true;
                Time.timeScale = 0;
            }
            else
            {
                pauseMenu.enabled = false;
                Time.timeScale = 1;
            }

        }
    }

    /// <summary>
    /// disables the pauseMenu
    /// and sets timeSacle to 1
    /// </summary>
    public void Resume()
    {
        pauseMenu.enabled = false;
        Time.timeScale = 1;
    }

    /// <summary>
    /// enables the tutorialMenu
    /// disables the pauseMenu
    /// </summary>
    public void Tutorial()
    {

        tutorialMenu.enabled = true;
        pauseMenu.enabled = false;

    }

    /// <summary>
    /// loads the scene with
    /// the name MainMenu
    /// </summary>
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    /// <summary>
    /// closes the application
    /// </summary>
    public void Quit()
    {
        Application.Quit();
    }

    
    /// <summary>
    ///Load the scene Tutorial
    /// </summary>
    public void LoadTutorial()
    {
        SceneManager.LoadScene("Tutorial");
    }

    /// <summary>
    ///Load the scene Level1
    /// </summary>
    public void Load1()
    {
        SceneManager.LoadScene("Level1");
    }

    /// <summary>
    ///Load the scene Level2
    /// </summary>
    public void Load2()
    {
        SceneManager.LoadScene("Level2");
    }

    /// <summary>
    ///Load the scene Level3
    /// </summary>
    public void Load3()
    {
        SceneManager.LoadScene("Level3");
    }

    /// <summary>
    ///Load the scene MoreSoon
    /// </summary>
    public void LoadMoreSoon()
    {
        SceneManager.LoadScene("MoreSoon");
    }

    /// <summary>
    /// disables the TutorialMenu
    /// enables the farbenTutorial
    /// </summary>
    public void FarbenTutorial()
    {
        farbenTutorial.enabled = true;
        tutorialMenu.enabled = false;
    }

    /// <summary>
    /// disables the TutorialMenu
    /// enables the steuerungTutorial
    /// </summary>
    public void SteuerungTutorial()
    {
        steuerungTutorial.enabled = true;
        tutorialMenu.enabled = false;
    }

    /// <summary>
    /// disables the TutorialMenu
    /// enables the rätselTutorial
    /// </summary>
    public void RätselTutorial()
    {
        goalOfTheGame.enabled = true;
        tutorialMenu.enabled = false;
    }

    /// <summary>
    /// enables the TutorialMenu
    /// disables the farbenTutorial
    /// disables the rätselTutorial
    /// disables the steuerungTutorial
    /// </summary>
    public void BackTutorial()
    {
        farbenTutorial.enabled = false;
        goalOfTheGame.enabled = false;
        steuerungTutorial.enabled = false;

        tutorialMenu.enabled = true;
    }

    /// <summary>
    /// enables the TutorialMenu
    /// disables the tutorialMenu
    /// </summary>
    public void BackToPauseMenu()
    {        
        pauseMenu.enabled = true;
        Time.timeScale = 0;
        tutorialMenu.enabled = false;

    }
}


