using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TunnelEndCollider : MonoBehaviour {
	public GameObject calenWarp;
	public Vector3 ejectForce;
	public float calenNewMass;

	public bool activateOnStart;
	public float delay;

	void OnTriggerEnter(Collider coll){
		StartCoroutine(StuffRoutine());
		GetComponent<Collider>().enabled = false;
	}

	void Start(){
		if (activateOnStart){
			OnTriggerEnter(null);
		}
	}

	IEnumerator StuffRoutine(){
		yield return new WaitForSeconds(delay);
		Calen.instance.maxFallSpeed = 99999;
		Calen.instance.transform.position = calenWarp.transform.position;
		Calen.instance.transform.rotation = Quaternion.identity;
		Calen.instance.rb.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;
		Calen.instance.rb.velocity = Vector3.zero;
		//Calen.instance.rb.mass = calenNewMass;
		Calen.instance.rb.AddForce(ejectForce, ForceMode.Impulse);

		

		CameraController.instance.transform.eulerAngles = new Vector3(45, CameraController.instance.transform.eulerAngles.y, 0);

		CameraController.instance.state = CameraState.TrackingPlayer;
		CameraController.instance.TrackTarget(true);

        MusicManager.instance.source.Stop();

		yield return new WaitForSeconds(3f);
		Calen.instance.canMove = true;
	}
}
