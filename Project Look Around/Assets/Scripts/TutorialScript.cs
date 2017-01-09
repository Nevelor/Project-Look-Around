using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class TutorialScript : MonoBehaviour
{
    public Canvas pauseMenu;
    public Canvas tutorialMenu;


	

    public void Back()
    {
        pauseMenu.enabled = true;
        tutorialMenu.enabled = false;

    }



}
