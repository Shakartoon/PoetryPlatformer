using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	private Rigidbody rb;
	public float moveSpeed;
	public float rotationSpeed;
	public float maxHeight;
	public float minHeight;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {

		float horizontalInput = Input.GetAxis ("Horizontal"); 
		float horizontalMovement = horizontalInput * Time.deltaTime * moveSpeed; 
		float verticalInput = Input.GetAxis ("Vertical"); 
		float rotationChange = verticalInput * Time.deltaTime * rotationSpeed;

		//transform.Rotate (0, x, 0); 
		//transform.Translate (0, 0, z); 
		transform.Rotate(0,0,rotationChange);
		float angle = (transform.eulerAngles.z +90)* Mathf.Deg2Rad;

		rb.velocity += horizontalMovement * new Vector3(Mathf.Cos(angle), Mathf.Sin(angle), 0);
		float clampedYPosition = Mathf.Clamp (transform.position.y, minHeight, maxHeight);
		transform.position = new Vector3 (transform.position.x, clampedYPosition, transform.position.z);

//		var x = Input.GetAxis ("Horizontal") * Time.deltaTime * 15.0f; 
//		var z = Input.GetAxis ("Vertical") * Time.deltaTime * 3.0f; 
//
//		//transform.Rotate (0, x, 0); 
//		transform.Translate (x, 0, 0); 
//

	}
}
