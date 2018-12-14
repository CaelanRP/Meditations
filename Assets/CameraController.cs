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

    public static Camera mainCam;

	public float lerpNormal, lerpFall;

    private void Awake()
    {
        instance = this;
        mainCam = GetComponent<Camera>();
    }
    // Use this for initialization
    void Start () {
		TrackTarget(true);
	}
	
	// Update is called once per frame
	void Update () {
		UpdateTarget();
		TrackTarget(false);
	}

	public void TrackTarget(bool snap = false){
		if (snap){
			UpdateTarget();
		}
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
			target = new Vector3(Calen.instance.transform.position.x, Calen.instance.transform.position.y, target.z);
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
