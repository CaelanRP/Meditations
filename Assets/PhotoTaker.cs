using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotoTaker : MonoBehaviour {
    public AudioClip sound;

    public void TakePhoto()
    {
        Calen.instance.photoFrame.color = Color.white;
        Calen.instance.photoInterior.color = Calen.instance.photoColor;

        MusicManager.instance.source.PlayOneShot(sound);
    }
}
