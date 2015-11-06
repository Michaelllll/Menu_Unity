using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class colision : MonoBehaviour {
	public static int contador =0;

	// Use this for initialization

	public Text txt;
	void OnCollisionEnter(Collision colision){
		//this.transform.position = new Vector3(0,-5f,0);
		Debug.Log ("colision");
		Destroy (this.gameObject);

		contador++;

			txt.text = "Puntuacion \n" + contador.ToString ();

	}



}
