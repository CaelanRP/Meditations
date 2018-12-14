using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractZone : MonoBehaviour {
    public bool inUse;
	public virtual void Trigger()
    {

    }

    void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.GetComponent<Calen>())
        {
            Calen.instance.currentInteract = this;
        }
    }

    void OnTriggerExit(Collider coll)
    {
        if (coll.gameObject.GetComponent<Calen>() && Calen.instance.currentInteract == this)
        {
            Calen.instance.currentInteract = null;
        }
    }
}
