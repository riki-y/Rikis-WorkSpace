using UnityEngine;
using System.Collections;

public class changeTextColor : MonoBehaviour {

	void Start () {
		GameObject.Find("GUI Text").guiText.text = "This is Sample!";
	}
	
	void Update () {
		transform.Rotate (1f, 1f, 0.1f);
		GameObject obj = GameObject.Find ("GUI Text");
		Color c = obj.guiText.color;
		if (Input.GetKey (KeyCode.RightArrow)) {
			c.a += 0.01f;
			if(c.a > 1.0f){
				c.a = 1.0f;
			}
			obj.guiText.color = c;
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			c.a -= 0.01f;
			if(c.a < 0.0f){
				c.a = 0.0f;
			}
			obj.guiText.color = c;
		}
	}
}
