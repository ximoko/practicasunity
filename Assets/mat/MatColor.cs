using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatColor : MonoBehaviour {

	private Material mat;
	private Animator anim;
	// Use this for initialization
	void Start () {
		
		Color myColor = new Color (Random.Range(0,1.0f),Random.Range(0,1.0f),Random.Range(0,1.0f),1);
		mat=GetComponent<Renderer>().material;
		mat.SetColor(ShaderID.ColorID,myColor);
	
		anim = GetComponent<Animator>();
		anim.SetBool(AnimatorHash.Jump,true); 
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
