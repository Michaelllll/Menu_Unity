using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;
public class Clock : MonoBehaviour {
	public static double timeAcum = 0;
	public Text txt;
	
	void Update()

	{   if (!spawn1.tiempo) {  
			if(!spawn1.parar)timeAcum += Math.Truncate (Time.deltaTime * 100) / 100;
			txt.text = "Tiempo\n" + timeAcum.ToString ("0.##");
		} else {
			txt.text = "";
		}

	}
}