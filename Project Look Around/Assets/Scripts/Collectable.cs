using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Script to collect in a 
/// spesific order
/// Dominik Betzler
/// </summary>
public class Collectable : MonoBehaviour
{
    /// <summary>
    /// script gets the number that
    /// the player must have to
    /// interact
    /// and the collectible
    /// </summary>
    public int colNumber;
    public GameObject collectable;
    
    

    /// <summary>
    /// Method called by
    /// hitting something
    /// </summary>
    /// <param name="other">the thing he colides with</param>
    private void OnTriggerEnter(Collider other)
    {
        /// <summary>
        /// if other has the tag player
        /// else nothing
        /// </summary>
        if (other.gameObject.CompareTag("Player"))
        {
            /// <summary>
            /// if collectableCounter
            /// from the script PlayerMovementCapsule
            /// has the same or a higher number
            /// it seets collectable active false and
            /// adds +1 to playerNumber
            /// </summary>
            if (PlayerMovementCaplsule.collectableCounter >= colNumber)
            {
                collectable.SetActive(false);
                PlayerMovementCaplsule.collectableCounter++;
            }
        }
    }
}
