/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour {

	public float mouseSensitivity = 100f;

	public Transform playerBody;

	float xRotation = 0f;


	void Start()
	{
		//Cursor.lockState = CursorLockMode.Locked;
	}

     void Update()
    {
		float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
		float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

		xRotation -= mouseY;

		xRotation = Mathf.Clamp(xRotation, -90f, 90f);

		transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

		playerBody.Rotate(Vector3.up * mouseX);

	}*/























    /*public float speed;
	public float sensitivity = 30.0f;
	public float WaterHeight = 15.5f;
	CharacterController character;
	public GameObject cam;
	float moveFB, moveLR;
	float rotX, rotY;
	public bool webGLRightClickRotation = true;
	public float gravity;

	public float jumpSpeed;
	Vector3 moveVector = Vector3.zero;


	void Start(){
		//LockCursor ();
		character = GetComponent<CharacterController> ();
		if (Application.isEditor) {
			webGLRightClickRotation = false;
			sensitivity = sensitivity * 1.5f;
		}
	}


	void CheckForWaterHeight(){
		if (transform.position.y < WaterHeight) {
			gravity = 0f;			
		} else {
			gravity = -9.8f;
		}
	}



	void Update(){
		moveFB = Input.GetAxis ("Horizontal") * speed;
		moveLR = Input.GetAxis ("Vertical") * speed;

		rotX = Input.GetAxis ("Mouse X") * sensitivity;
		rotY = Input.GetAxis ("Mouse Y") * sensitivity;

		//rotX = Input.GetKey (KeyCode.Joystick1Button4);
		//rotY = Input.GetKey (KeyCode.Joystick1Button5);

		CheckForWaterHeight ();


		Vector3 movement = new Vector3 (moveFB, gravity, moveLR);



		if (webGLRightClickRotation) {
			if (Input.GetKey (KeyCode.Mouse0)) {
				CameraRotation (cam, rotX, rotY);
			}
		} else if (!webGLRightClickRotation) {
			CameraRotation (cam, rotX, rotY);
		}

		//movement = transform.rotation * movement; 
		//character.Move (movement * Time.deltaTime);

		if (character.isGrounded && Input.GetButton("Jump"))
		{

			moveVector.y = jumpSpeed;
			moveVector.y -= gravity * Time.deltaTime;
		}
	}


	void CameraRotation(GameObject cam, float rotX, float rotY){		
		transform.Rotate (0, rotX * Time.deltaTime, 0);
		cam.transform.Rotate (-rotY * Time.deltaTime, 0, 0);
	}

	public float jumpSpeed;
	public float gravity;
	public float MoveSpeed;
	float rotX, rotY;
	public GameObject cam;
	public bool webGLRightClickRotation = true;
	public float sensitivity = 30.0f;

	Vector3 movevector  =Vector3.zero;
	CharacterController characterController;


	void Start()
	{
		characterController = GetComponent<CharacterController>();
		if (Application.isEditor)
		{
			webGLRightClickRotation = false;
			sensitivity = sensitivity * 1.5f;
		}
	}


     void Update()
    {

		rotX = Input.GetAxis("Mouse X") * sensitivity;
		rotY = Input.GetAxis("Mouse Y") * sensitivity;

		movevector.x = Input.GetAxis("Horizontal") * MoveSpeed;
		movevector.z = Input.GetAxis("Vertical") * MoveSpeed;

		if (characterController.isGrounded && Input.GetButton("Jump"))
			movevector.y = jumpSpeed;
		movevector.y -= gravity * Time.deltaTime;

		characterController.Move(movevector * Time.deltaTime);


		if (webGLRightClickRotation)
		{
			if (Input.GetKey(KeyCode.Mouse0))
			{
				CameraRotation(cam, rotX, rotY);
			}
		}
		else if (!webGLRightClickRotation)
		{
			CameraRotation(cam, rotX, rotY);
		}

	}
	void CameraRotation(GameObject cam, float rotX, float rotY)
	{
		transform.Rotate(0, rotX * Time.deltaTime, 0);
		cam.transform.Rotate(-rotY * Time.deltaTime, 0, 0); 
	}*/





