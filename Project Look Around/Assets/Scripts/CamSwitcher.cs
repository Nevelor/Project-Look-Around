using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Class for switching between 2 Cameras
/// Not used at the moment!
/// maybe later for bird view Camera
/// Dominik Betzler
/// </summary>
public class CamSwitcher : MonoBehaviour {

    /// <summary>
    /// the class gets the two cameras
    /// camTPS for the third person cam
    /// camBirdView for the other camer,
    /// that can be implemented
    /// </summary>
    public Camera camTPS;
    public Camera camBirdView;



	/// <summary>
    /// in start it uses the method
    /// wich enables one cam and disables the other
    /// </summary>
	private void Start ()
    {
        EnableTPSCam();
	}
	

    /// <summary>
    /// Every frame the method 
    /// CamSwitch get called
    /// </summary>
    private void Update()
    {
        CamSwitch();
    }

    /// <summary>
    /// by pressing V either the EnableTPSCam or
    /// the EnableBirdCam method are called
    /// by checking wich camera is enabled
    /// </summary>
    private void CamSwitch()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            if (camTPS.enabled == false)
            {
                EnableTPSCam();
            }
            else
            {
                EnableBirdCam();
            }
        }
    }

    /// <summary>
    /// enables the camTPS 
    /// and disables the camBirdView
    /// </summary>
    private void EnableTPSCam()
    {
        camTPS.enabled = true;
        camBirdView.enabled = false;
    }

    /// <summary>
    /// disables the camTPS 
    /// and enables the camBirdView
    /// </summary>
    private void EnableBirdCam()
    {
        camTPS.enabled = false;
        camBirdView.enabled = true;
    }

	
}
