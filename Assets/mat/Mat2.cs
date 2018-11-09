using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mat2 : MonoBehaviour {

	private Material material;
	
	// Use this for initialization
	void Start () 
	{		
		Renderer renderer=GetComponent<Renderer>();

		Color myColor = new Color (Random.Range(0,1.0f),Random.Range(0,1.0f),Random.Range(0,1.0f),1);

		MaterialPropertyBlock block = new MaterialPropertyBlock();

		renderer.GetPropertyBlock(block);
		//Modificamos el material aqui:
		block.SetColor(ShaderID.ColorID,myColor);
		//------------------------------
		renderer.SetPropertyBlock(block);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
