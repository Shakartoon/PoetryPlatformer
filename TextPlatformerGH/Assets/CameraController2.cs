using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController2 : MonoBehaviour {

	GameObject playerObj; 
	Vector3 cameraOffSet; 

	void Start () {

		playerObj = GameObject.Find ("PlayerModel2"); 
		cameraOffSet = new Vector3 (0, 6, -9); 
	}
	
	void Update () {

		transform.position = playerObj.transform.position + cameraOffSet; 
	}
}
