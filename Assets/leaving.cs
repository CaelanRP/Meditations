using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leaving : MonoBehaviour {
    public float speed;
    private void FixedUpdate()
    {
        transform.position += (Vector3.left * speed);
    }
}
