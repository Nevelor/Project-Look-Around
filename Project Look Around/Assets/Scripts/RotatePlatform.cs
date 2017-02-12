using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Script for rotating things by steping
/// on them or other thingt with a GameObject
/// with the Tag Player
/// Dominik Betzler
/// </summary>
public class RotatePlatform : MonoBehaviour
{
    /// <summary>
    /// Gets the reference for the objact
    /// thad we want to rotate
    /// </summary>
    public GameObject rotatePlatform;


    /// <summary>
    /// Activates be collision
    /// </summary>
    /// <param name="other">the thing that collides with it</param>
    private void OnTriggerEnter(Collider other)
    {
        /// <summary>
        /// applies if the other thing 
        /// has the Tag Player
        /// </summary>
        if (other.gameObject.CompareTag("Player"))
        {


            /// <summary>
            /// rotates the object
            /// around his own Y axis by 45 degree
            /// </summary>
            /// <param name="Vector3.up">rotates around Y axis</param>
            /// <param name="45f">rotates by 45 degree</param>
            /// <param name="Space.Self">rotates around his own and not around the world axis</param>
            rotatePlatform.transform.Rotate(Vector3.up, 45f, Space.Self);

        }
    }
   
    

}
