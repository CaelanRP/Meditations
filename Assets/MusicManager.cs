using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour {
    public AudioClip startClip, creepyLoop, dramaticDrop;
    public static MusicManager instance;
    [HideInInspector]
    public AudioSource source;
    public AudioSource stepSource;
    bool intro;
	void Awake()
    {
        instance = this;
        source = GetComponent<AudioSource>();
    }

    public void StartCreepy()
    {
        StartCoroutine(IntroRoutine());
    }

    public void Drop()
    {
        intro = false;
        source.Stop();
        source.loop = false;
        source.clip = dramaticDrop;
        source.Play();
    }

    public void End()
    {
        source.Stop();
        source.loop = true;
        source.clip = creepyLoop;
        source.Play();
    }

    IEnumerator IntroRoutine()
    {
        intro = true;
        source.loop = false;
        source.PlayOneShot(startClip);
        yield return new WaitForSeconds(startClip.length);

        if (intro)
        {
            source.loop = true;
            source.clip = creepyLoop;
            source.Play();
        }
    }
}
