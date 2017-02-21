using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float movementSpeed = 5.0f;
	public float mouseSensitivity = 2.0f;

	private float fowardSpeed;
	private float sideSpeed;
	private float rotLeftRight;
	private float rotTopDown;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		MovementHandler ();
	}

	void MovementHandler() {

		fowardSpeed = Input.GetAxis("Vertical") * movementSpeed;
		sideSpeed = Input.GetAxis("Horizontal") * movementSpeed;
		rotLeftRight = Input.GetAxis ("Mouse X") * mouseSensitivity;
		rotTopDown = Input.GetAxis ("Mouse Y") * mouseSensitivity;

		transform.Rotate (-rotTopDown, rotLeftRight, 0);

		CharacterController cc = GetComponent<CharacterController> ();

		Vector3 speed = new Vector3 (sideSpeed, 0, fowardSpeed);

		speed = transform.rotation * speed;

		cc.SimpleMove (speed);

	}

}
