using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerMovementCaplsule : MonoBehaviour {

    public float speed = 10f;
    public float jumpForce = 8f;
    public float gravity = 30f;
    private Vector3 moveDir = Vector3.zero;

    void Start()
    {

    }


    void Update()
    {

        if(Input.GetMouseButton(1))
        {

            // Get mouse input
            float moveHorizontal = Input.GetAxis("Mouse Y");

            Debug.Log("Mouse used! " + moveHorizontal);

            // Check for changes
            if (moveHorizontal == 0)
            {
                return;
            }
            
            // Calculate camera rotation
            float newY = transform.rotation.eulerAngles.x + (moveHorizontal * 10f);
            float newX = 0f;
            float newZ = 0f;

            // Set new camera rotation
            transform.rotation = Quaternion.Euler(newX, newY, newZ);

        }

        return;
        /*

        CharacterController controller = gameObject.GetComponent<CharacterController>();

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
        */
    }
}
