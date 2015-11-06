using UnityEngine;
using System.Collections;

public class inicio : MonoBehaviour {
	public static int nivel=0;
	
	public void EventoBoton () {
		spawn1.parar=false;
		Clock.timeAcum=0;
		colision.contador=0;
		Time.timeScale = 1;
		Application.LoadLevel (1);
	}
	
	
}