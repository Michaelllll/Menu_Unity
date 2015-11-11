using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MenuNavigationScript : MonoBehaviour {
	
	public RectTransform mainMenuPanel; //reference for MainMenupanel
	public Animator mainMenuAnimator; //Animator reference
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.Escape)){ //check if escape key is pressed
			if((int)mainMenuPanel.localScale.x==0){ //check if scale of MainMenu Panel is 0
				mainMenuAnimator.Play("reaparecer"); //play fade in animation
			}
		}
	}
}