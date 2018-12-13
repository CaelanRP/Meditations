using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CameraState{TrackingPlayer, TrackingObject, PlayerFall}
public class CameraController : MonoBehaviour {
	public CameraState state = CameraState.TrackingPlayer;
	public Vector3 offset;
	Vector3 target;

	GameObject trackingObject;

	public static CameraController instance;

	public float lerpNormal, lerpFall;
	// Use this for initialization
	void Start () {
		instance = this;
		UpdateTarget();
		TrackTarget(true);
	}
	
	// Update is called once per frame
	void Update () {
		UpdateTarget();
		TrackTarget(false);
	}

	void TrackTarget(bool snap = false){
		float lerp = state == CameraState.PlayerFall ? lerpFall : lerpNormal;

		Vector3 vec = target + offset;
		if (snap){
			transform.position = vec;
		}
		else{
			transform.position = Vector3.Lerp(transform.position, vec, lerp * Time.deltaTime);
		}
	}

	void UpdateTarget(){
		if (state == CameraState.TrackingPlayer){
			target = Calen.instance.transform.position;
		}
		else if (state == CameraState.PlayerFall){
			target = new Vector3(target.x, Calen.instance.transform.position.y, target.z);
		}
		else if (state == CameraState.TrackingObject){
			target = trackingObject.transform.position;
		}
	}

	public void TrackObject(GameObject obj){
		trackingObject = obj;
		state = CameraState.TrackingObject;
	}
}
