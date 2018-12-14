using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CameraState{TrackingPlayer, TrackingObject, PlayerFall, EndScene}
public class CameraController : MonoBehaviour {
	public CameraState state = CameraState.TrackingPlayer;
	public Vector3 offset;
	Vector3 target;

	GameObject trackingObject;

	public static CameraController instance;

    public static Camera mainCam;

	public float lerpNormal, lerpFall;

    public Transform halfwayPoint, endPoint;
    public float halfwayTime, endTime;

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

    public void EndScene()
    {
        state = CameraState.EndScene;
        StartCoroutine(EndSceneRoutine());
    }

    IEnumerator EndSceneRoutine()
    {
        yield return new WaitForSeconds(2);

        float timeStarted = Time.time;
        Vector3 startingPos = transform.position;
        while (Time.time - timeStarted < halfwayTime)
        {
            float currentTime = Time.time - timeStarted;
            transform.position = Vector3.Lerp(startingPos, halfwayPoint.position, currentTime / halfwayTime);
            yield return null;
        }

        MusicManager.instance.End();

        timeStarted = Time.time;
        startingPos = transform.position;
        while (Time.time - timeStarted < endTime)
        {
            float currentTime = Time.time - timeStarted;
            transform.position = Vector3.Lerp(startingPos, endPoint.position, currentTime / endTime);
            yield return null;
        }
        yield return new WaitForSeconds(1);
        Application.Quit();
        Debug.Break();
    }

    public void TrackTarget(bool snap = false){
        if (state == CameraState.EndScene)
        {
            return;
        }
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
