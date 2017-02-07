using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCameraControler : MonoBehaviour
{
    public GameObject player;

    /// <summary>
    /// Contains the multiplier for the movement.
    /// </summary>
    public float movementSpeed = 2.5f;

    /// <summary>
    /// Contains the multiplier for the wheel.
    /// </summary>
    public float wheelSpeed = 10f;

    /// <summary>
    /// Contains the multiplier for the mouse.
    /// </summary>
    public float mouseSpeed = 1.5f;

    /// <summary>
    /// Contains the multiplier for the up-/downwards movements.
    /// </summary>
    public float upSpeed = 1.5f;

    /// <summary>
    /// Contains the minimum position on the Y axis.
    /// </summary>
    protected float minYAxis = 30f;

    /// <summary>
    /// Contains the maximum position on the Z axis.
    /// </summary>
    protected float maxZAxis = 1000f;

    /// <summary>
    /// Contains the maximum position on the Z axis.
    /// </summary>
    protected float maxXAxis = 1000f;

    /// <summary>
    /// Contains the multiplier for the camera focus.
    /// </summary>
    protected float focusSpeed = 0.0025f;

    /// <summary>
    /// Contains the time for the current focus animation.
    /// </summary>
    protected float focusCurrent = 0f;

    /// <summary>
    /// Contains the current animation state as flag.
    /// </summary>
    protected bool focusAnimation = false;

    /// <summary>
    /// Provides a reference for the current focus object.
    /// </summary>
    protected GameObject focusObject;

    /// <summary>
    /// Update functionality for the current object, called each frame.
    /// </summary>
    void FixedUpdate()
    {
        /*
        // Check for focus animation
        if (focusAnimation)
        {
            CalculateCameraFocus();
        }
        */
       
        

        

    }

    
    /*
    /// <summary>
    ///  Calculates the camera focus for the linked object.
    /// </summary>
    void CalculateCameraFocus()
    {
        if (focusObject.GetComponent<ShipController>().HasShadowObject())
        {
            focusCurrent = (focusCurrent >= 1f) ? focusCurrent : focusCurrent + focusSpeed;
            transform.position = Vector3.Lerp(transform.position, focusObject.GetComponent<ShipController>().shadowObject.transform.position, focusCurrent);
            transform.rotation = Quaternion.Lerp(transform.rotation, focusObject.GetComponent<ShipController>().shadowObject.transform.rotation, focusCurrent);
        }
    }

   
    */

}
