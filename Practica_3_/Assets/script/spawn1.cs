using UnityEngine;
using System.Collections;
public class spawn1 : MonoBehaviour {

	public GameObject prefab;
	public GameObject prefab1;
	public GameObject prefab2;
	public GameObject prefab3;

	public bool fin=true;
	public static bool parar=false;
	//private Rigidbody rb;
	public static int contGlobal =0;
	public static double tiemNivel =0;
	public static bool tiempo=false;
	// Use this for initialization
	void Start () {
		//rb = GetComponent<Rigidbody> ();
		//Instantiate (prefab, transform.position, transform.rotation)
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (transform.position.y<1.7 && fin) {
			parar=true;
			//rb.velocity = new Vector3(0,0,0);
			//rb.angularVelocity=new Vector3(0,0,0);
			//rb.useGravity = false;



			//Debug.Log("puntuacion" + )
			Instantiate (prefab, transform.position, transform.rotation) ;

			fin=false;
		
		
			Time.timeScale = 0;

		}
		if (transform.position.z>85&& fin) {
			//Instantiate (prefab, transform.position, transform.rotation)

			if(inicio.nivel<1)Instantiate (prefab1, transform.position, transform.rotation) ;
			Instantiate (prefab2, transform.position, transform.rotation) ;
			Instantiate (prefab3, transform.position, transform.rotation) ;

			fin=false;
			tiemNivel=Clock.timeAcum;
			contGlobal+=colision.contador;

			tiempo=true;

			Clock.timeAcum=0;
			Time.timeScale = 0;
		}

	}
}
