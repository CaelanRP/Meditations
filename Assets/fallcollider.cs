using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallcollider : MonoBehaviour {
    public float spinTime,angleTime;
    bool lerping;
    public Transform lerpTarget;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (lerping)
        {
            Vector3 target = new Vector3(lerpTarget.position.x, Calen.instance.transform.position.y, lerpTarget.position.z);
            Calen.instance.transform.position = Vector3.Lerp(Calen.instance.transform.position, target, Time.deltaTime);
        }
	}

    private void OnTriggerEnter(Collider other)
    {
        StartCoroutine(FlipRoutine());
        GetComponent<Collider>().enabled = false;
    }

    IEnumerator FlipRoutine()
    {
        lerping = true;
        Calen.instance.rb.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezePositionY;

        float timeStarted = Time.time;
        while(Time.time - timeStarted < spinTime)
        {
            float angle = 180 * ((Time.time - timeStarted) / spinTime);
            CameraController.instance.transform.eulerAngles = new Vector3(CameraController.instance.transform.eulerAngles.x, CameraController.instance.transform.eulerAngles.y, angle);
            yield return null;
        }

        timeStarted = Time.time;
        while(Time.time - timeStarted < angleTime)
        {
            float angle = 45 + (35 * ((Time.time - timeStarted) / angleTime));
            CameraController.instance.transform.eulerAngles = new Vector3(angle, CameraController.instance.transform.eulerAngles.y, CameraController.instance.transform.eulerAngles.z);
            yield return null;
        }
        lerping = false;

        Calen.instance.rb.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezePositionZ;
        Calen.instance.maxFallSpeed = 999999;
    }
}
