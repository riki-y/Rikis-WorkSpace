using UnityEngine;
using System.Collections;

public class changeGrass : MonoBehaviour {
	Texture texture1;
	Color color1;
	float size = 1.0f;

	void Start () {
		GameObject.Find ("GUI Text").guiText.text = "Texture sample";
		texture1 = (Texture)Resources.Load ("Grass (Hill)");
		color1 = renderer.material.color;
		renderer.material.mainTexture = texture1;
		renderer.material.color = Color.white;
	}

	void Update () {
		transform.Rotate (1f, 1f, 0.1f);
		if (Input.GetKey (KeyCode.LeftArrow)) {
			size += 0.01f;
			renderer.material.SetTextureScale("_MainTex", new Vector2(size, size));
		}
		if(Input.GetKey(KeyCode.RightArrow)){
			size -= 0.01f;
			if(size < 0){
				size = 0f;
			}
			renderer.material.SetTextureScale("_MainTex", new Vector2(size, size));
		}
		if (Input.GetKeyDown (KeyCode.Space)) {
			renderer.material.mainTexture = texture1;
			renderer.material.color = Color.white;
		}
		if (Input.GetKeyUp (KeyCode.Space)) {
			renderer.material.mainTexture = null;
			renderer.material.color = color1;
		}
	}
}
