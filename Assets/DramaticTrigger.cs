using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DramaticTrigger : MonoBehaviour {
	public GameObject tire, noGoingBackCollider;
    public float delay;
	void OnCollisionEnter(Collision coll){
		CameraController.instance.TrackObject(tire);
		noGoingBackCollider.SetActive(true);
        GetComponent<Collider>().enabled = false;
        MusicManager.instance.StartCreepy();
        StartCoroutine(FreezePlayer());
	}

    IEnumerator FreezePlayer()
    {
        Calen.instance.canMove = false;
        yield return new WaitForSeconds(delay);
        Calen.instance.canMove = true;
    }
}
