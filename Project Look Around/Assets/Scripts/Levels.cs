using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class Levels : MonoBehaviour {

    public Canvas mainMenu;
    public Canvas levelsMenu;

    public void Back()
    {
        mainMenu.enabled = true;
        levelsMenu.enabled = false;
    }

    public void Level1()
    {
        SceneManager.LoadScene("Level1");
    }

    public void Level2()
    {
        SceneManager.LoadScene("Level2");
    }

    public void Level3()
    {
        SceneManager.LoadScene("Level3");
    }

    public void Level4()
    {
        SceneManager.LoadScene("Level4");
    }

}
