using UnityEngine;
using System.Collections;

public class changeColor : MonoBehaviour {

	void Start () {
	}
	
	void Update () {
		transform.Rotate (1f, 1f, 0.1f);
		Color c = renderer.material.color;
		if (Input.GetKey (KeyCode.RightArrow)) {
			c.r += 0.01f;
			if (c.r > 1.0f) {
				c.r = 1.0f;
			}

			c.b -= 0.01f;
			if (c.b < 0.0f) {
				c.b = 0.0f;
			}
			renderer.material.color = c;
		}

		if (Input.GetKey (KeyCode.LeftArrow)) {
			c.r -= 0.01f;
			if(c.r < 0.0f){
				c.r = 0.0f;
			}

			c.b += 0.01f;
			if(c.b > 1.0f){
				c.b = 1.0f;
			}
			renderer.material.color = c;
		}
	}
}
