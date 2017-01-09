using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class TutorialScript : MonoBehaviour
{
    public Canvas pauseMenu;
    public Canvas tutorialMenu;


	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    public void Back()
    {
        pauseMenu.enabled = true;
        tutorialMenu.enabled = false;

    }



}
