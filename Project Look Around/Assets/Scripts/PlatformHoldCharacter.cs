using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Valerian Wolff
/// </summary>
public class PlatformHoldCharacter : MonoBehaviour {

     void OnTriggerEnter(Collider col)
    {
        col.transform.parent = gameObject.transform;
    }
     void OnTriggerExit(Collider col)
    {
        col.transform.parent = null;
    } 
}
