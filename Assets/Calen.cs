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

    public SpriteRenderer photoFrame, photoInterior;
    public Color photoColor;

    public InteractZone currentInteract;

    public bool _canMove
    {
        get
        {
            return canMove && !sitting;
        }
    }
    public bool canMove;
    public bool sitting;

    public Animator anim;

    public GameObject prompt;
	void Awake(){
		instance = this;
        rb = GetComponent<Rigidbody>();
        anim = GetComponentInChildren<Animator>();
	}
	// Use this for initialization
	void Start () {
		cam = Camera.main;
	}

    public void StartBall()
    {
        sitting = true;
        anim.SetTrigger("startball");
    }

    public void StartShovel()
    {
        sitting = true;
        anim.SetTrigger("startshovel");
    }

    // Update is called once per frame
    void Update () {
		HandleInput();

        photoFrame.color = Color.Lerp(photoFrame.color, Color.clear, 2 * Time.deltaTime);
        photoInterior.color = Color.Lerp(photoInterior.color, Color.clear, 2 * Time.deltaTime);

        prompt.SetActive(currentInteract != null && !currentInteract.inUse);
    }

    void HandleInput(){
        if (Input.GetButtonDown("Jump"))
        {
            if (sitting)
            {
                sitting = false;
                anim.SetTrigger("stopsitting");
                if (currentInteract != null)
                {
                    currentInteract.inUse = false;
                }
            }
            else
            {
                if (currentInteract != null)
                {
                    currentInteract.inUse = true;
                    currentInteract.Trigger();
                }
            }
        }
       
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

        if (xMove == 0 || !_canMove)
        {
            // decelerate x
            moveVector = new Vector3(GetDeceleratedValue(moveVector.x), moveVector.y, moveVector.z);
        }

        if (zMove == 0 || !_canMove)
        {
            //decelerate z
            moveVector = new Vector3(moveVector.x, moveVector.y, GetDeceleratedValue(moveVector.z));
        }
        if (_canMove){
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
