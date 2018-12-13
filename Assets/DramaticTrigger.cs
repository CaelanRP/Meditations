using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DramaticTrigger : MonoBehaviour {
	public GameObject tire, noGoingBackCollider;
	void OnCollisionEnter(Collision coll){
		CameraController.instance.TrackObject(tire);
		noGoingBackCollider.SetActive(true);
		gameObject.SetActive(false);
	}
}
