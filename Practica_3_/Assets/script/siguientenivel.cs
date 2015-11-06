using UnityEngine;
using System.Collections;

public class siguientenivel : MonoBehaviour {


	public void EventoBoton () {
		spawn1.tiempo = false;
		colision.contador=0;
		inicio.nivel++;
		Time.timeScale = 1;
		Application.LoadLevel (inicio.nivel);
	}
	

}
