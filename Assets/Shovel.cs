using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shovel : InteractZone
{
    SpriteRenderer spr;
    private void Awake()
    {
        spr = GetComponent<SpriteRenderer>();
    }
    public override void Trigger()
    {
        Calen.instance.sitting = true;
        Calen.instance.StartShovel();
    }

    private void Update()
    {
        spr.enabled = !inUse;
    }
}