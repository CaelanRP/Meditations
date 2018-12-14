using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimHelper : MonoBehaviour {
    public ParticleSystem sand;
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
    }

    
}
