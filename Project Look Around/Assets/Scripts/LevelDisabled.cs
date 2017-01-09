using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class LevelDisabled : MonoBehaviour
{
    public Button level2Button;
    public Button level3Button;
    public Button level4Button;

    public Image level2Image;
    public Image level3Image;
    public Image level4Image;


    void Start()
    {
        level2Button.enabled = false;
        level3Button.enabled = false;
        level4Button.enabled = false;

        level2Image.enabled = true;
        level3Image.enabled = true;
        level4Image.enabled = true;

    }

    void LateUpdate ()
    {
        if (level2Button.enabled == true)
        {
            level2Image.enabled = false;
        }

        if (level3Button.enabled == true)
        {
            level3Image.enabled = false;
        }

        if (level4Button.enabled == true)
        {
            level4Image.enabled = false;
        }
    }

    public void EnableAll()
    {
        level2Button.enabled = true;
        level3Button.enabled = true;
        level4Button.enabled = true;
    }

    public void DisableAll()
    {
        level2Button.enabled = false;
        level3Button.enabled = false;
        level4Button.enabled = false;
    }

}
