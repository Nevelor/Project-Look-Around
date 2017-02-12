using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// Class for the player movement
/// and his rotation
/// Dominik Betzler (PlayerRotation)
/// Valerian Wolff (PlayerMovement)
/// </summary>
public class PlayerMovementCaplsule : MonoBehaviour
{
    /// <summary>
    /// gets the GameObject player
    /// and some float variables
    /// and a Vector3(0,0,0)
    /// with name moveDir
    /// </summary>
    public GameObject player;

    public float speed = 10f;
    public float jumpForce = 8f;
    public float gravity = 30f;
    private Vector3 moveDir = Vector3.zero;



    /// <summary>
    /// every frame the two methods
    /// are called
    /// </summary>
    private void Update()
    {
        PlayerMovement();
        PlayerRotation();
    }

    /// <summary>
    /// method that rotates the player
    /// with mouse input
    /// </summary>
    private void PlayerRotation()
    {
        /// <summary>
        /// by pressing the right mouse button
        /// the player can rotate by mouse moving
        /// </summary>
        if (Input.GetMouseButton(1))
        {

            /// <summary>
            /// Get mouse input
            /// </summary>
            float moveHorizontal = Input.GetAxis("Mouse Y") * -1;

            Debug.Log("Mouse used! " + moveHorizontal);

            /// <summary>
            /// Check for changes
            /// </summary>
            if (moveHorizontal == 0)
            {
                return;
            }

            /// <summary>
            /// Calculate camera rotation
            /// </summary>
            float newY = transform.rotation.eulerAngles.y + (moveHorizontal * 50f);
            float newX = 0f;
            float newZ = 0f;


            /// <summary>
            /// Set new camera rotation
            /// </summary>
            transform.rotation = Quaternion.Euler(newX, newY, newZ);

        }

    }

    /// <summary>
    /// method that controlles
    /// the movement of the player
    /// </summary>
    private void PlayerMovement()
    {
        CharacterController controller = player.GetComponent<CharacterController>();

        /// <summary>
        /// if player is 
        /// </summary>
        if (controller.isGrounded)
        {
            moveDir = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
            moveDir = transform.TransformDirection(moveDir);
            moveDir *= speed;

            if (Input.GetButtonDown("Jump"))
            {
                moveDir.y = jumpForce;
            }
        }

        moveDir.y -= gravity * Time.deltaTime;

        controller.Move(moveDir * Time.deltaTime);
    }
}
