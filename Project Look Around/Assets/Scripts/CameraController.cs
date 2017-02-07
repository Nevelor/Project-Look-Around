using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public GameObject focusObject;

    protected enum cameraTypes { Top = 1 };
    protected int cameraType;

    [Range(0, 100)]
    public float distanceUpwards = 25f;
    [Range(0, 100)]
    public float distanceBackwards = 25f;

    public bool animationUse = true;
    [Range(0, 1)]
    public float animationSpeed = 0.1f;
    [Range(0, 1)]
    public float animationCurrent = 0f;

    // Use this for initialization
    void Start()
    {

        // Set initial camera type
        cameraType = (int)cameraTypes.Top;
        
    }

    // Update is called once per frame
    void Update()
    {

        switch (cameraType)
        {
            case (int)cameraTypes.Top:
                handleTopCamera();
                break;
            default:
                handleTopCamera();
                break;
        }

    }

    /*
     * ###################
     * ##### Cameras #####
     * ###################
     */

    public void handleTopCamera()
    {

        // Calculate position behind the focused car
        Vector3 position = focusObject.transform.position;
        Quaternion rotation = focusObject.transform.rotation;

        position += Vector3.up * distanceUpwards;
        position += focusObject.transform.forward * distanceBackwards * -1;

        // Move camera to new position (without animation)
        if (!animationUse)
        {
            transform.position = position;
            transform.rotation = rotation;
            transform.LookAt(focusObject.transform);
            return;
        }

        // Move camera to new position (with animation)
        // EXPERIMENTAL
        animationCurrent = (animationCurrent >= 1f) ? animationCurrent : animationCurrent + animationSpeed;
        transform.position = Vector3.Lerp(transform.position, position, animationCurrent);
        transform.rotation = Quaternion.Lerp(transform.rotation, rotation, animationSpeed);
        transform.LookAt(focusObject.transform);
        if (animationCurrent >= 1f)
        {
            animationUse = false;
        }

    }

    /*
     * ########################
     * ##### Focus Object #####
     * ########################
     */

    public GameObject GetFocusObject()
    {
        return focusObject;
    }

    public bool HasFocusObject()
    {
        return focusObject is GameObject;
    }

    public void SetFocusObject(GameObject _focusObject)
    {
        focusObject = _focusObject;
    }

}
