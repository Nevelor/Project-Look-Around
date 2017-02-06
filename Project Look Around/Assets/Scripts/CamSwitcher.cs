using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CamSwitcher : MonoBehaviour {

    public Camera camMouse;
    public Camera camLocked;



	
	private void Start ()
    {
        camMouse.enabled = true;
        camLocked.enabled = false;
	}
	
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            if (camMouse.enabled == false)
            {
                camMouse.enabled = true;
                camLocked.enabled = false;
            }
            else
            {
                camMouse.enabled = false;
                camLocked.enabled = true;
            }
        }

        
    }
	
}
