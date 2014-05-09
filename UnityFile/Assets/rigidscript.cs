using UnityEngine;
using System.Collections;

public class rigidscript : MonoBehaviour {

	void Start () {
	}
	
	void Update () {	
		if (Input.GetKey (KeyCode.UpArrow)) {
			transform.rigidbody.AddForce (0, 0, 1);
		}
		if (Input.GetKey (KeyCode.DownArrow)) {
			transform.rigidbody.AddForce (0, 0, -1);
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.rigidbody.AddForce (1, 0, 0);
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.rigidbody.AddForce (-1, 0, 0);
		}

	}
}
