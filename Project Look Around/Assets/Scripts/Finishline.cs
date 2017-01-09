using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Finishline : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadSceneAsync("MainMenue", LoadSceneMode.Additive);
    }
}
