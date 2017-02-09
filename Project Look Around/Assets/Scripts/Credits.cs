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
    /// this method loads the scene
    /// with the name MainMenu
    /// </summary>
    public void Back()
    {
        SceneManager.LoadScene("MainMenu");
    }
	
	
	
}
