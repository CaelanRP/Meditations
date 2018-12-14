using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flower : InteractZone
{
    public override void Trigger()
    {
        Calen.instance.sitting = true;
        Calen.instance.anim.SetTrigger("startsitting");
    }
}
