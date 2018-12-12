using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calen : MonoBehaviour {
	Camera cam;
	public float walkSpeed, jumpForce;
	public static Calen instance;
	void Awake(){
		instance = this;
	}
	// Use this for initialization
	void Start () {
		cam = Camera.main;
	}
	
	// Update is called once per frame
	void Update () {
		//transform.LookAt(cam.transform);
		//transform.rotation = Camera.main.transform.rotation;
		//transform.eulerAngles = new Vector3(-5f, transform.eulerAngles.y, transform.eulerAngles.z);
	}
}
