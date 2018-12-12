using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
public class TripTroupeSpriteRenderer : MonoBehaviour {

	public Mesh mesh;
	public Material mat;
	public Texture sprite;
	public Color color = Color.white;
	public Color glow = Color.clear;
	public Color eliteColor = Color.gray;
	public bool elite = false;
	private float timeOffset;
	public float strength = .01f;
	const string mainTex = "_MainTex";

	const string c = "_Color";
	const string g = "_Glow";
	const string ec = "_EliteColor";
	const string e = "_Elite";
	const string timeOffsetTex = "_TimeOffset";
	const string str = "_Strength";
	MaterialPropertyBlock mpb;
	MeshRenderer mr;
	MeshFilter mf;
	// Use this for initialization
	void Start () {
		mpb = new MaterialPropertyBlock ();
		mr = GetComponent<MeshRenderer> ();
		mf = GetComponent<MeshFilter> ();
		if (mat != null){
			mr.material = mat;
		}
		if (mf != null) {
			mf.mesh = mesh;
		}
		timeOffset = (float)TTUtil.random.NextDouble ();
		UpdateVisuals ();
	}

	void Update(){
		UpdateVisuals ();
	}

	void UpdateVisuals(){
		if (mpb != null) {
			mr.GetPropertyBlock (mpb);
		} else {
			mpb = new MaterialPropertyBlock ();
		}
		if (sprite != null) {
			mpb.SetTexture (mainTex, sprite);
		}
		mpb.SetColor (c, color);
		mpb.SetColor (g, glow);
		//mpb.SetColor (ec, new Color(163f/255f, 0, 0));
		if (elite) {
			mpb.SetFloat (e, 1);
		} else {
			mpb.SetFloat (e, 0);
		}
		mpb.SetFloat (timeOffsetTex, timeOffset);
		mpb.SetFloat (str, strength);
		mr.SetPropertyBlock (mpb);
	}

	void OnValidate () {
		//Start ();
	}


	void OnEnable(){
		if (mr)
			mr.enabled = true;
	}

	void OnDisable(){
		if (Application.isPlaying) {
			if (mr) {
				mr.enabled = false;
			}
		}
	}

}
