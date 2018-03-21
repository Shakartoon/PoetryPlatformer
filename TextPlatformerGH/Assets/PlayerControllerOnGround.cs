using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerOnGround : MonoBehaviour {

	public float moveSpeed = 3.0f;
	public float jumpHeight = 2.0f; 

	public bool grounded = true; 
	public float jumpPower = 10.0f; 




	void Start () {

	}
	
	void Update () {

		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.Translate (moveSpeed * Input.GetAxis ("Horizontal") * Time.deltaTime, 0f, 0f);
		
		}

		if (Input.GetKeyDown (KeyCode.Space)) { 

			transform.Translate (0f, 0f, jumpHeight * Time.deltaTime); 

		//	this.gameObject.GetComponent<Rigidbody> ().AddForce (Vector3.up) * jumpPower;  
		
		//this is a fun one for player movement in the future 
		//transform.Translate (2f, jumpHeight * Input.GetAxis ("Vertical") * Time.deltaTime, 2f); 

		}


	}

}
