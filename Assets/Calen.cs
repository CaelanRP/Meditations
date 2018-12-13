using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calen : MonoBehaviour {
	Camera cam;
	public float walkAccel, walkDecel, walkMaxSpeed, jumpForce;
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

	void FixedUpdate(){
	    HandleInputFixed();
	}


	void HandleInputFixed(){
        float xMove = Input.GetAxis("Horizontal");
        float zMove = Input.GetAxis("Vertical");

        Vector3 moveVector = new Vector3(xMove, 0, zMove);

        if (xMove == 0)
        {
            //decelerate x
        }

        if (zMove == 0)
        {
            //decelerate z
        }


        if (xMove != 0 || zMove != 0)
        {
            Walk(moveVector);
        }
        
    }

    void Walk(Vector3 moveVector)
    {
        moveVector = Vector3.ClampMagnitude(moveVector, 1);

        moveVector *= walkAccel;

        moveVector = Vector3.ClampMagnitude(moveVector, walkMaxSpeed);
    }
}
