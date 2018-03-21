using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Z_Scale : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
				
		transform.localScale += new Vector3 (0, 0, 1f); 

		if (transform.localScale.z > 300f) {
			transform.localScale += new Vector3 (0, 0, -150f); 
		} 
		
	}
}
