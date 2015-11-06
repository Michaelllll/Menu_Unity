using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class json : MonoBehaviour {
	public  static int maximo;
	public Text puntuaciones;

	void Start () {
	
		int input  = PlayerPrefs.GetInt (inicio.nivel.ToString());
		maximo=PlayerPrefs.GetInt (inicio.nivel.ToString());
		puntuaciones.text = "Record\n "+input.ToString();

	}
	
	
	
	public void fbotonGrabar(){

		int inputfieldGO = colision.contador;

		int aux = inputfieldGO;

		if (aux >= maximo) {
			maximo = aux;
			PlayerPrefs.SetInt (inicio.nivel.ToString(), maximo);
			PlayerPrefs.Save ();



		}

	}	
  
}


