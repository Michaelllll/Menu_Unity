using UnityEngine;
using System.Collections;

public class spawn : MonoBehaviour {
	
	public GameObject prefab;

	// Use this for initialization
	void Start () {
		//Instantiate (prefab, transform.position, transform.rotation)
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (colision.contador==15) {
			//Instantiate (prefab, transform.position, transform.rotation)
			Instantiate (prefab, transform.position, transform.rotation) ;
			colision.contador=0;
		}
	}
}
