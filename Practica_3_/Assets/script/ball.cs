using UnityEngine;
using System.Collections;

public class ball : MonoBehaviour {

	public float speed;
	private Rigidbody rb;
	private bool recto=true;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();

		rb.AddForce(Vector3.forward * 18f, ForceMode.Impulse);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape)) Application.Quit();
		if (!spawn1.parar) {

			if (Input.GetTouch (0).phase == TouchPhase.Began) {

					if (recto) {
						rb.velocity = new Vector3 (0, 0, 0);
						rb.angularVelocity = new Vector3 (0, 0, 0);
						rb.AddForce (Vector3.left * 10f, ForceMode.Impulse);
						recto = false;
			
					} else {
						rb.velocity = new Vector3 (0, 0, 0);
						rb.angularVelocity = new Vector3 (0, 0, 0);
						rb.AddForce (Vector3.forward * 10f, ForceMode.Impulse);
						recto = true;

					}
				}
				if (!recto) {

					rb.AddForce (Vector3.left * 10f, ForceMode.Force);

			
				} else {

					rb.AddForce (Vector3.forward * 10f, ForceMode.Force);
			
				}
			}


		
	}
}
