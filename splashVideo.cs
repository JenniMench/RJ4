using UnityEngine;
using System.Collections;

public class splashVideo : MonoBehaviour {
    public MovieTexture movieTexture;
	bool movieStarted=false;
    void Start() {
    }
	void Update (){
		
		if(movieTexture.isPlaying == false){
			if(movieStarted==false && movieTexture.isReadyToPlay == true){
				movieTexture.Play();
			}
			else if(movieStarted==true){
				Application.LoadLevel("Level 2");	
			}
		}
	}
	void OnGUI() {
		GUI.Box(new Rect(0,0,Screen.width,Screen.height), movieTexture);
	}
}