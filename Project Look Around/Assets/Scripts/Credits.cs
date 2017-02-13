using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
/// <summary>
/// Class for all buttons in
/// the Credits scene
/// Dominik Betzler
/// </summary>
public class Credits : MonoBehaviour
{
    public GameObject text1;
    public GameObject text2;

    private void Start()
    {
        text1.SetActive(true);
        text2.SetActive(false);
    }

    public void TextChanger()
    {
        if(text1.activeSelf == true)
        {
            text2.SetActive(true);
            text1.SetActive(false);
        }
        else
        {
            text1.SetActive(true);
            text2.SetActive(false);
        }
    }

    /// <summary>
    /// this method loads the scene
    /// with the name MainMenu
    /// </summary>
    public void Back()
    {
        SceneManager.LoadScene("MainMenu");
    }
	
	
	
}
