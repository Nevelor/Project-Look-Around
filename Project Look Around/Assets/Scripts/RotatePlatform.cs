using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePlatform : MonoBehaviour
{
    public GameObject rotatePlatform;



    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            rotatePlatform.transform.Rotate(Vector3.right, 45f, Space.Self);

            
        }
    }

    

}
