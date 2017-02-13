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
    /// <summary>
    /// Gets the text input for
    /// the Credits
    /// </summary>
    public GameObject text1;
    public GameObject text2;

    /// <summary>
    /// Gets the text for the Button
    /// </summary>
    public GameObject nextText1;
    public GameObject nextText2;

    /// <summary>
    /// Sets nextText1 and text1
    /// actife true to show them
    /// Sets nextText2 and text2
    /// actife false
    /// </summary>
    private void Start()
    {
        text1.SetActive(true);
        text2.SetActive(false);
        nextText1.SetActive(true);
        nextText2.SetActive(false);
    }
    /// <summary>
    /// method for the button
    /// to show the right text
    /// and simulate a site change
    /// </summary>
    public void TextChanger()
    {
        /// <summary>
        /// if text1 is active it
        /// sets nextText1 and text1
        /// actife false to show them
        /// Sets nextText2 and text2
        /// actife true
        /// </summary>
        if (text1.activeSelf == true)
        {
            text2.SetActive(true);
            text1.SetActive(false);
            nextText2.SetActive(true);
            nextText1.SetActive(false);
        }
        /// <summary>
        /// else the opposite happens
        /// </summary>
        else
        {
            text1.SetActive(true);
            text2.SetActive(false);
            nextText1.SetActive(true);
            nextText2.SetActive(false);
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
