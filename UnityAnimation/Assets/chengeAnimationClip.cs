using UnityEngine;
using System.Collections;

public class chengeAnimationClip : MonoBehaviour {

	void Start () {
		GameObject.Find("GUI Text").guiText.text = "AnimationClip sample";

		AnimationClip clipA = new AnimationClip();
		AnimationCurve curveA = AnimationCurve.Linear(0f, 3f, 3f, 3f);
		Keyframe keyA = new Keyframe(1.5f, 10f);
		curveA.AddKey(keyA);
		clipA.SetCurve("", typeof(Transform), "localPosition.z", curveA);
		clipA.wrapMode = WrapMode.Loop;
		animation.AddClip(clipA, "anim1");

		AnimationClip clipB = new AnimationClip();
		AnimationCurve curveB = AnimationCurve.Linear(0f, 3f, 3f, 3f);
		Keyframe key1 = new Keyframe(0.75f, 7f);
		curveB.AddKey(key1);
		Keyframe key2 = new Keyframe(1.5f, 3f);
		curveB.AddKey(key2);
		Keyframe key3 = new Keyframe(2.25f,7f);
		curveB.AddKey (key3);
		clipB.SetCurve("", typeof(Transform), "localPosition.z", curveB);
		clipB.wrapMode = WrapMode.Loop;
		animation.AddClip(clipB, "anim2");

		animation.Play ("anim1");
	}
	
	void Update () {
		transform.Rotate(1f, 1f, 1f);

		if(Input.GetKeyDown(KeyCode.Space)){
			if(animation.IsPlaying ("anim1")){
				animation.CrossFade("anim2", 5.0f);
//				animation.PlayQueued("anim2", QueueMode.PlayNow);
				GameObject.Find("GUI Text").guiText.text = "Anim2!";
			} else if(animation.IsPlaying("anim2")) {
				animation.CrossFade("anim1", 5.0f);
//				animation.PlayQueued("anim1",QueueMode.PlayNow);
				GameObject.Find("GUI Text").guiText.text = "Anim1!";
			}
		}
	}
}
