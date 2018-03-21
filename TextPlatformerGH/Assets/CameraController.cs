using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public Transform player;
	private Vector3 offset;

	// Use this for initialization
	void Start () {
		offset = transform.position - player.position;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 unconstrainedPosition = player.position + offset;
		transform.position = new Vector3 (unconstrainedPosition.x, transform.position.y, transform.position.z);
	}
}
