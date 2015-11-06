#pragma strict

var bola : Transform;
function Start () {
	bola = GameObject.FindGameObjectWithTag("Player").transform;
}

function Update () {
transform.position.x = bola.position.x;
transform.position.y = bola.position.y+5;
transform.position.z = bola.position.z-12;
//transform.LookAt(bola);

}