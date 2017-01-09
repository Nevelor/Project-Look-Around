using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Finishline : MonoBehaviour
{
    public Canvas winMenu;


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Finish"))
        {
            Time.timeScale = 0;
            winMenu.enabled = true;
        }

        
    }
}
