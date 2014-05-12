using UnityEngine;
using System.Collections;

public class liveLight : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GameObject.Find("GUI Text").guiText.text = "Light Sample!";
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (1f, 1f, 0.1f);
		GameObject obj = GameObject.Find ("Directional light");
		Color c = obj.light.color;
		if (Input.GetKey (KeyCode.RightArrow)) {
			c.r += 0.01f;
			if(c.r > 1.0f){
				c.r = 1.0f;
			}
			obj.light.color = c;
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			c.r -= 0.01f;
			if(c.r < 0.0f){
				c.r = 0.0f;
			}
			obj.light.color = c;
		}
	}
}
