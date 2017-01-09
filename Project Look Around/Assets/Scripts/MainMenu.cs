using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class MainMenu : MonoBehaviour {

    public Canvas mainMenu;
    public Canvas levelsMenu;


	void Start ()
    {
        mainMenu.enabled = true;
        levelsMenu.enabled = false;
	}
	
    public void Levels()
    {
        mainMenu.enabled = false;
        levelsMenu.enabled = true;
    }
	
    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }
	
    public void Quit()
    {
        Quit();
    }

}
