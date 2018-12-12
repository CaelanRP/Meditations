using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CameraState{TrackingPlayer, TrackingSpot}
public class CameraController : MonoBehaviour {
	public CameraState state = CameraState.TrackingPlayer;
	public Vector3 offset;
	Vector3 target;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void UpdateTarget(){
		if (state == CameraState.TrackingPlayer){
			target = Calen.instance.transform.position;
		}
	}
}
