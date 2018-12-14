﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallcollider : MonoBehaviour {
    public float spinTime;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        StartCoroutine(FlipRoutine());
        GetComponent<Collider>().enabled = false;
    }

    IEnumerator FlipRoutine()
    {

        Calen.instance.rb.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezePositionY;

        float timeStarted = Time.time;
        while(Time.time - timeStarted < spinTime)
        {
            float angle = 180 * ((Time.time - timeStarted) / spinTime);
            CameraController.instance.transform.eulerAngles = new Vector3(CameraController.instance.transform.eulerAngles.x, CameraController.instance.transform.eulerAngles.y, angle);
            yield return null;
        }

        yield return new WaitForSeconds(0.5f);
        Calen.instance.rb.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezePositionZ;
        Calen.instance.maxFallSpeed = 999999;
    }
}
