using UnityEngine;
using System.Collections;


public class Story1 : MonoBehaviour {

	public TextAsset storyFile;
	public GUISkin guiSkin;
	public GUISkin guiSkinNarrator;
	public Texture2D[] background;
	public Texture[] picture;
	
    string[] storyLines1;
	int lineCtr = 1;
	int backgroundCtr = 0;
	bool pHere = true;
	char[] temp={':'};
	
    void Start () {
		
        storyLines1 = ( storyFile.text.Split( '\n' ) );
		if(storyLines1[0].Split(temp,2)[1] == "0") {
			pHere = false;
		}
    }

	void Update () {
		 if (Input.GetKeyDown("return")) {
           	lineCtr++;
		 }
	}
	
	private int searchName(string name){
		int picCtr;
		
		for(picCtr=0; picCtr<picture.Length; picCtr++) {
			if(name == picture[picCtr].name){
				break;
			}
		}
		
		return picCtr>=picture.Length?-1:picCtr;
	}
	
	private void OnGUI() {
		if(lineCtr>=storyLines1.Length){
			return;
		}
		
		GUI.skin = guiSkin;
		int picCtr;
		
		string nameTalker = storyLines1[lineCtr].Split(temp,2)[0];
		string dialog = storyLines1[lineCtr].Split(temp,2)[1];
		
		Debug.Log(nameTalker);
		
		//if it is a background
		if (nameTalker == "bg") {
			backgroundCtr++;
			lineCtr++;
			return;
		}
		
		//if name is narrator
		if(nameTalker=="narrator"){
			GUI.skin = guiSkinNarrator;
			GUI.DrawTexture(new Rect(0,0,Screen.width,Screen.height),background[background.Length-1]);
			GUI.Box (new Rect (0,0,800,600), dialog);	
			return;
		}
		
		
		GUI.DrawTexture(new Rect(0,0,Screen.width,Screen.height),background[backgroundCtr]);
		
		if(pHere == true) {
			
			picCtr = searchName(nameTalker);
			if(nameTalker == "prince") {
				GUI.DrawTexture(new Rect(20,120,220,400),picture[0]);
				GUI.Box (new Rect (0,Screen.height - 250,800,260), dialog);	
			}
			else {
				Debug.Log(nameTalker);
				GUI.DrawTexture(new Rect(580,50,170,400),picture[picCtr]);
				GUI.Box (new Rect (0,Screen.height - 250,800,260), dialog);	
			}
			return;
		}
		
		picCtr = searchName(nameTalker);
		
		if(picCtr%2==0){
			GUI.DrawTexture(new Rect(20,120,220,400),picture[picCtr]);
			GUI.Box (new Rect (0,Screen.height - 250,800,260), dialog);	
		}
		else {
			GUI.DrawTexture(new Rect(580,50,170,400),picture[picCtr]);
			GUI.Box (new Rect (0,Screen.height - 250,800,260), dialog);	
		}
	}
}

