using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calen : MonoBehaviour {
	Camera cam;
	public float walkAccel, walkDecel, walkMaxSpeed, maxFallSpeed;
	public static Calen instance;
    [HideInInspector]
    public Vector3 moveVector;
    [HideInInspector]
    public Rigidbody rb;

    public bool canMove;

    Animator anim;
	void Awake(){
		instance = this;
        rb = GetComponent<Rigidbody>();
        anim = GetComponentInChildren<Animator>();
	}
	// Use this for initialization
	void Start () {
		cam = Camera.main;
	}
	
	// Update is called once per frame
	void Update () {
		HandleInput();
	}

    void HandleInput(){

    }

	void FixedUpdate(){
	    HandleInputFixed();

        if (rb.velocity.y < -maxFallSpeed){
            rb.velocity = Vector3.ClampMagnitude(rb.velocity, maxFallSpeed);
        }
	}

    float GetDeceleratedValue(float init){
        if (init > 0){
            return Mathf.Max(0, init - walkDecel);
        }
        else if (init < 0){
            return Mathf.Min(0, init + walkDecel);
        }
        else{
            return 0;
        }
    }


	void HandleInputFixed(){
        float xMove = Input.GetAxisRaw("Horizontal");
        float zMove = Input.GetAxisRaw("Vertical");

        if (xMove == 0 || !canMove)
        {
            // decelerate x
            moveVector = new Vector3(GetDeceleratedValue(moveVector.x), moveVector.y, moveVector.z);
        }

        if (zMove == 0 || !canMove)
        {
            //decelerate z
            moveVector = new Vector3(moveVector.x, moveVector.y, GetDeceleratedValue(moveVector.z));
        }
        if (canMove){
            anim.SetBool("walking", xMove != 0 || zMove != 0);
            
            if (xMove != 0 || zMove != 0)
            {
                // Accelerate in the direction of the inputVector
                Vector3 inputVector = Vector3.ClampMagnitude(new Vector3(xMove, 0, zMove), 1);
                inputVector *= walkAccel;
                moveVector += inputVector;
                Walk();
            }
        }
        else{
            anim.SetBool("walking", false);
        }
        
    }

    void Walk()
    {
        moveVector = Vector3.ClampMagnitude(moveVector, walkMaxSpeed);
        rb.MovePosition(transform.position + moveVector);
    }
}
