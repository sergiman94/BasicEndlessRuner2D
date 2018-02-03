using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	public string playGameLevel1;

	public void PlayGame(){
			
		Application.LoadLevel (playGameLevel1);
	}

	public void QuitGame(){
	
		Application.Quit ();
	
	}
}
