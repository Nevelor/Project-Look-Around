using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class MainControllerScript : MonoBehaviour
{
    public Canvas pauseMenu;
    public Canvas tutorialMenu;
    public Canvas levelWin;
    public Canvas levelLose;

    public Canvas steuerungTutorial;
    public Canvas rätselTutorial;
    public Canvas farbenTutorial;

    // Use this for initialization
    private void Start()
    {
        StartThings();
    }

    // Update is called once per frame
    private void Update()
    {
        EnablePauseMenu();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="other">all other things
    /// the player colliedes with</param>
    private void OnTriggerEnter(Collider other)
    {
        /// <summary>
        /// If the other thing
        /// has the Tag "ColYellow"
        /// </summary>
        if (other.gameObject.CompareTag("ColYellow"))
        {
            other.gameObject.SetActive(false);
        }

        /// <summary>
        /// If the other thing
        /// has the Tag "ColBlue"
        /// </summary>
        if (other.gameObject.CompareTag("ColBlue"))
        {
            other.gameObject.SetActive(false);
        }

        /// <summary>
        /// If the other thing
        /// has the Tag "ColRed"
        /// </summary>
        if (other.gameObject.CompareTag("ColRed"))
        {
            other.gameObject.SetActive(false);
        }

        /// <summary>
        /// If the other thing
        /// has the Tag "ColGreen"
        /// </summary>
        if (other.gameObject.CompareTag("ColGreen"))
        {
            other.gameObject.SetActive(false);
        }

        /// <summary>
        /// If the other thing
        /// has the Tag "ColTime"
        /// </summary>
        if (other.gameObject.CompareTag("ColTime"))
        {
            other.gameObject.SetActive(false);
        }
    }

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
        rätselTutorial.enabled = false;
        farbenTutorial.enabled = false;
    }

   

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

    public void Resume()
    {
        pauseMenu.enabled = false;
        Time.timeScale = 1;
    }

    


    public void Tutorial()
    {

        tutorialMenu.enabled = true;
        pauseMenu.enabled = false;

    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void NextLevelTutorialTo1()
    {
        Load1();
    }

    public void NextLevel1To2()
    {
        Load2();
    }

    public void NextLevel2To3()
    {
        Load3();
    }

    public void NextLevel3To4()
    {
        Load4();
    }

    public void NextLevel4To5()
    {
        SceneManager.LoadScene("MoreSoon");
    }


    /// <summary>
    /// nun alle Reload Funktionen für die Level
    /// </summary>
    /// Beginnend mit dem Tutorial

    public void LoadTutorial()
    {
        SceneManager.LoadScene("Tutorial");
    }

    public void Load1()
    {
        SceneManager.LoadScene("Level1");
    }

    public void Load2()
    {
        SceneManager.LoadScene("Level2");
    }


    public void Load3()
    {
        SceneManager.LoadScene("Level3");
    }

    public void Load4()
    {
        SceneManager.LoadScene("Level4");
    }

    public void FarbenTutorial()
    {
        farbenTutorial.enabled = true;
        tutorialMenu.enabled = false;
    }

    public void SteuerungTutorial()
    {
        steuerungTutorial.enabled = true;
        tutorialMenu.enabled = false;
    }
    
    public void RätselTutorial()
    {
        rätselTutorial.enabled = true;
        tutorialMenu.enabled = false;
    }

    public void BackTutorial()
    {
        farbenTutorial.enabled = false;
        rätselTutorial.enabled = false;
        steuerungTutorial.enabled = false;

        tutorialMenu.enabled = true;
    }
}
