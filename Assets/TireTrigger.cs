using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TireTrigger : MonoBehaviour {
	public GameObject beforeColliders, afterColliders;
	public Collider groundCollider;
	void OnCollisionEnter(Collision coll){
		Debug.Log("BOOM");
		beforeColliders.SetActive(false);
		groundCollider.enabled = false;
		afterColliders.SetActive(true);
		Calen.instance.canMove = false;

		Calen.instance.rb.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY;

		CameraController.instance.state = CameraState.PlayerFall;

		Destroy(gameObject);
	}
}
