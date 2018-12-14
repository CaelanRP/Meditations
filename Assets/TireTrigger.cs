using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TireTrigger : MonoBehaviour {
	public GameObject beforeColliders, afterColliders;
	public Collider groundCollider;

    public float musicDelay;
	void OnCollisionEnter(Collision coll){
		Debug.Log("BOOM");
		beforeColliders.SetActive(false);
		groundCollider.enabled = false;
		afterColliders.SetActive(true);
		Calen.instance.canMove = false;

		Calen.instance.rb.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezePositionZ;

		CameraController.instance.state = CameraState.PlayerFall;

        GetComponent<Collider>().enabled = false;

        Parent.instance.FreakOut();

        StartCoroutine(SpookyRoutine());
	}

    IEnumerator SpookyRoutine()
    {
        yield return new WaitForSeconds(musicDelay);
        MusicManager.instance.Drop();
    }
}
