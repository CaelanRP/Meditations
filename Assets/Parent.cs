using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parent : MonoBehaviour {
    public float followDistanceStart, followDistanceFinish;
    public float followSpeed, photoTime, stopPhotoTime;

    public enum State { Standing, Following, Photographing, FreakingOut}
    public State state;

    float waitTime;

    Animator anim;

    public static Parent instance;

    private void Awake()
    {
        anim = GetComponentInChildren<Animator>();
        instance = this;
    }

    private void Update()
    {
        UpdatePhoto();
    }

    public void FreakOut()
    {
        state = State.FreakingOut;
        anim.SetTrigger("freakout");
    }

    public void UpdatePhoto()
    {
        if (state == State.Standing && Calen.instance.sitting)
        {
            waitTime += Time.deltaTime;
            if (waitTime >= photoTime)
            {
                state = State.Photographing;
                anim.SetTrigger("takephoto");
                waitTime = 0;
            }
        }
        else if (state == State.Photographing && !Calen.instance.sitting)
        {
            waitTime += Time.deltaTime;
            if (waitTime >= stopPhotoTime)
            {
                state = State.Standing;
                anim.SetTrigger("stopphoto");
                waitTime = 0;
            }
        }
        else
        {
            waitTime = 0;
        }
    }

    private void FixedUpdate()
    {
        if (state == State.Standing && Vector3.Distance(transform.position, Calen.instance.transform.position) > followDistanceStart && Calen.instance.transform.position.x > transform.position.x)
        {
            state = State.Following;
            anim.SetBool("walking", true);
        }
        else if (state == State.Following && Vector3.Distance(transform.position, Calen.instance.transform.position) < followDistanceFinish)
        {
            state = State.Standing;
            anim.SetBool("walking", false);
        }

        HandleFollow();
    }

    void HandleFollow()
    {
        if (state == State.Following)
        {
            Vector3 moveVec = Calen.instance.transform.position - transform.position;
            moveVec = new Vector3(moveVec.x, 0, moveVec.z);
            Vector3.ClampMagnitude(moveVec, 1);

            transform.position += (moveVec * followSpeed);
        }
    }
}
