using UnityEngine;
using System.Collections;

public class myscript : MonoBehaviour {

	void Start () {	
	}
	
	void Update () {
		transform.Rotate (1f, 1f, 0.1f);
		if (Input.GetKeyDown (KeyCode.Space)) {
			renderer.enabled = false;
		}
		if (Input.GetKeyUp (KeyCode.Space)) {
			renderer.enabled = true;
		}
	}
}
