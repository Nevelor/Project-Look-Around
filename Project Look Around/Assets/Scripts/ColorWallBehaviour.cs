using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ColorWallBehaviour : MonoBehaviour {

    /// <summary>
    /// Gets the Gameobjects for the player and
    /// all other Empty GameObjectes that hold 
    /// the colored walls
    /// </summary>
    public GameObject player;
    public GameObject blueWalls;
    public GameObject redWalls;
    public GameObject yellowWalls;
    public GameObject blackWalls;





    private void LateUpdate ()
    {
        AllWallsEndabled();
	}

    /// <summary>
    /// put all methods for wall enabeling 
    /// together in on method 
    /// </summary>
    private void AllWallsEndabled()
    {
        BlueWallEandabled();
        RedWallEandabled();
        YellowWallEandabled();
        BlackWallEandabled();
    }

    /// <summary>
    /// eanables or disables all
    /// blue walls
    /// </summary>
    private void BlueWallEandabled()
    {
        if (player.GetComponent<Renderer>().material.color == Color.blue)
        {
            blueWalls.SetActive(true);
        }
        else
        {
            blueWalls.SetActive(false);
        }
    }

    /// <summary>
    /// eanables or disables all
    /// red walls
    /// </summary>
    private void RedWallEandabled()
    {
        if (player.GetComponent<Renderer>().material.color == Color.red)
        {
            redWalls.SetActive(true);
        }
        else
        {
            redWalls.SetActive(false);
        }
    }

    /// <summary>
    /// eanables or disables all
    /// yellow walls
    /// </summary>
    private void YellowWallEandabled()
    {
        if (player.GetComponent<Renderer>().material.color == Color.yellow)
        {
            yellowWalls.SetActive(true);
        }
        else
        {
            yellowWalls.SetActive(false);
        }
    }

    /// <summary>
    /// eanables or disables all
    /// black walls
    /// </summary>
    private void BlackWallEandabled()
    {
        if (player.GetComponent<Renderer>().material.color == Color.black)
        {
            blackWalls.SetActive(true);
        }
        else
        {
            blackWalls.SetActive(false);
        }
    }

}
