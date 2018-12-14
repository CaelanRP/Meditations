using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spookyparent : InteractZone
{
    public GameObject leavingboys;

    public override void Trigger()
    {
        GetComponent<SpriteRenderer>();
        CameraController.instance.EndScene();
        Calen.instance.gameObject.SetActive(false);
        leavingboys.SetActive(true);
        Destroy(gameObject);
    }
}
