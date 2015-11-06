using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
public class finNivel : MonoBehaviour {


	
	public Text txt;
	void Update(){
		if (json.maximo >= colision.contador) {
			if(inicio.nivel<1){
			txt.text = "Puntuacion Global\n" + spawn1.contGlobal.ToString () + "\nPuntuacion nivel\n" + colision.contador.ToString ()
				+ "\nTiempo nivel\n" + spawn1.tiemNivel.ToString ("0.##");
			}
			else
			{
				txt.text = "Puntuacion Global\n" + spawn1.contGlobal.ToString () + "\nPuntuacion nivel\n" + colision.contador.ToString ()
					+ "\nTiempo nivel\n" + spawn1.tiemNivel.ToString ("0.##")+"\nFIN DEL JUEGO"; 
			}
		} else {
			if(inicio.nivel<1){
			txt.text = "!!!NUEVO RECORD!!!\nPuntuacion Global\n" + spawn1.contGlobal.ToString () + "\nPuntuacion nivel\n" + colision.contador.ToString ()
				+ "\nTiempo nivel\n" + spawn1.tiemNivel.ToString ("0.##"); 
			}
			else
			{
				txt.text = "!!!NUEVO RECORD!!!\nPuntuacion Global\n" + spawn1.contGlobal.ToString () + "\nPuntuacion nivel\n" + colision.contador.ToString ()
					+ "\nTiempo nivel\n" + spawn1.tiemNivel.ToString ("0.##")+"\nFIN DEL JUEGO"; 
			}
		
		}

	}
	

}
