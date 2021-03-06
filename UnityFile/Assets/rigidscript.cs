﻿using UnityEngine;
using System.Collections;

public class rigidscript : MonoBehaviour {
	float dgr = 0;
	int power = 0;

	void Start () {
	}
	
	void Update () {
		Vector3 pos = transform.position;

		if (Input.GetKeyDown (KeyCode.Space)) {
			power = 0;
		}
		if (Input.GetKey (KeyCode.Space)) {
			power++;
		}
		if (Input.GetKeyUp (KeyCode.Space)) {
			Vector3 v = Camera.main.transform.position;
			v -= pos;
			v *= power * -1;
			v.y = 0;
			transform.rigidbody.AddForce(v);
		}

		if (Input.GetKey (KeyCode.UpArrow)) {
			transform.rigidbody.AddForce (0, 0, 1);
		}
		if (Input.GetKey (KeyCode.DownArrow)) {
			transform.rigidbody.AddForce (0, 0, -1);
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			Camera.main.transform.RotateAround(pos, new Vector3(0, 10, 0), -0.1f);
			dgr += 0.1f;
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			Camera.main.transform.RotateAround(pos, new Vector3(0, 10, 0), 0.1f);
			dgr -= 0.1f;
		}

		float d = (2 * Mathf.PI) * (dgr / 360);
		float x = Mathf.Sin (d);
		float y = Mathf.Cos (d);
		x *= 10f;
		y *= 10f;
		pos.x += x;
		pos.y += 10f;
		pos.z -= y;
		Camera.main.transform.position = pos;
	}
}
