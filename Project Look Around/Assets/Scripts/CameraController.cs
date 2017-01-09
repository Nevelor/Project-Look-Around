using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]

public class CameraController : MonoBehaviour {

    public float MoveSpeed;
    public float RotationSpeed;
    CharacterController charContr;

	
	void Start () {
        charContr = GetComponent<CharacterController>();
	}
	
	
	void Update () {
        Vector3 forward = Input.GetAxis("Vertical") * transform.TransformDirection(Vector3.forward) * MoveSpeed;
        transform.Rotate(new Vector3(0, Input.GetAxis("Horizontal") * RotationSpeed * Time.deltaTime, 0));
        charContr.Move(forward * Time.deltaTime);
        charContr.SimpleMove(Physics.gravity);
	}
}
