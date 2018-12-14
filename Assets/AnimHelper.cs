using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimHelper : MonoBehaviour {
    public ParticleSystem sand;
    public AudioClip sandAudio;
    AudioSource source;
    public AudioClip step;
    public float minPitch, maxPitch;

    public void Awake()
    {
        source = GetComponent<AudioSource>();
    }

    public void Step()
    {
        source.clip = step;
        source.pitch = Random.Range(minPitch, maxPitch);
        source.Play();
    }

    public void Emit()
    {
        sand.Emit(5);
        MusicManager.instance.source.PlayOneShot(sandAudio);
    }

    
}
