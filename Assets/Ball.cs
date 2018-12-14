using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : InteractZone {
    SpriteRenderer spr;
    private void Awake()
    {
        spr = GetComponent<SpriteRenderer>();
    }
    public override void Trigger()
    {
        Calen.instance.sitting = true;
        Calen.instance.StartBall();
    }

    private void Update()
    {
        spr.enabled = !inUse;
    }
}
