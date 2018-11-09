using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NonAllocSample : MonoBehaviour 
{
	RaycastHit[] hits;
	public Gameobject obj;

	Camera camera;
	// Use this for initialization
	void Start ()
	{
		hits = new RaycastHit[10];
		if((object)obj != null) Debug.Log("Name: "+ obj.name);
		camera = Camera.main;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (input.GetMouseButtonDown(0))
		{
			Ray ray = cam.ScreenPointToRay(Input.mousePosition);
			// Mierda = Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			/* genera garbage memory
			RaycastHit[] hits = Physics.RaycastAll(ray);

			if (hits.Length > 0)
			{
				for (int i = 0; i < hits.Length; i++)
				{
					Debug.Log(hits[i].transform.name);
				}
			}
			*/
			int numHits = Physics.RaycastNonAlloc(ray,hits);

			if (numHits > 0)
			{
				for (int i = 0; i < numHits; i++)
				{
					Debug.Log(hits[i].transform.name);
				}
			}

		}

	}
}
