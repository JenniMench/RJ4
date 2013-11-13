using UnityEngine;
using System.Collections;


public class Story1 : MonoBehaviour {

	public TextAsset storyFile;
	public GUISkin guiSkin;
	public GUISkin guiSkin2;
	
	//change backgrounds to an array
	public Texture2D[] _background;
	public Texture2D background;
	public Texture2D background2;
	public Texture2D background3;
	public Texture arrowHead;
	
	//use array as pictures
	public Texture[] picture;
	
	public Texture hKing;
	public Texture hPrince;
	public Texture hSoldier;
	public Texture fatMerchant;
	
    string[] storyLines1;
	int ctr = 0;
    void Start () {
         storyLines1 = ( storyFile.text.Split( '\n' ) );
    }

	void Update () {
		 if (Input.GetKeyDown("return")) {
           	ctr++;
		}
	}
	
	private void OnGUI() {
		Texture arrowhead = Resources.Load("arrowhead") as Texture;
		
		
		if (background != null && ctr <= 15) {
			GUI.skin = guiSkin;
	        GUI.DrawTexture(new Rect(0,0,Screen.width , Screen.height),background);
		}
		else if(ctr >=17 && ctr < 21) {
			GUI.skin = guiSkin;
			GUI.DrawTexture(new Rect(0,0,Screen.width , Screen.height),background2);
		}
		else {
			GUI.skin = guiSkin2;
			GUI.DrawTexture(new Rect(0,0,Screen.width , Screen.height),background3);
		}
		
		
		char[] temp={':'};
		string nameTalker = storyLines1[ctr].Split(temp,2)[0];
		string dialog = storyLines1[ctr].Split(temp,2)[1];
		
		//change this to a loop to make the code generic
		
		//the rectangle width must be large
		switch(ctr){
			case 0:
				GUI.DrawTexture(new Rect(20,120,200,400),hKing);
				GUI.Box (new Rect (0,Screen.height - 250,600,250), dialog);	
				GUI.DrawTexture(new Rect(520,530,37,32),arrowHead);
				break;
			case 1:
				GUI.DrawTexture(new Rect(630,150,140,300),hPrince);
				GUI.Box (new Rect (Screen.width - 600,Screen.height - 250,600,250), dialog);
				GUI.DrawTexture(new Rect(720, 530,37,32),arrowHead);
				break;
			case 2:
				GUI.DrawTexture(new Rect(20,120,200,400),hKing);
				GUI.Box (new Rect (0,Screen.height - 250,600,250), dialog);	
				GUI.DrawTexture(new Rect(520,530,37,32),arrowHead);
				break;
			case 3:
				GUI.DrawTexture(new Rect(20,120,200,400),hKing);
				GUI.Box (new Rect (0,Screen.height - 250,600,250), dialog);	
				GUI.DrawTexture(new Rect(520,530,37,32),arrowHead);
				break;
			case 4:
				GUI.DrawTexture(new Rect(630,150,140,300),hPrince);
				GUI.Box (new Rect (Screen.width - 600,Screen.height - 250,600,250), dialog);
				GUI.DrawTexture(new Rect(720, 530,37,32),arrowHead);
				break;
			case 5:
				GUI.DrawTexture(new Rect(20,120,200,400),hKing);
				GUI.Box (new Rect (0,Screen.height - 250,600,250), dialog);	
				GUI.DrawTexture(new Rect(520,530,37,32),arrowHead);
				break;
			case 6:
				GUI.DrawTexture(new Rect(630,150,140,300),hPrince);
				GUI.Box (new Rect (Screen.width - 600,Screen.height - 250,600,250), dialog);
				GUI.DrawTexture(new Rect(720, 530,37,32),arrowHead);
				break;
			case 7:
				GUI.DrawTexture(new Rect(20,120,200,400),hKing);
				GUI.Box (new Rect (0,Screen.height - 250,600,250), dialog);	
				GUI.DrawTexture(new Rect(520,530,37,32),arrowHead);
				break;
			case 8:
				GUI.DrawTexture(new Rect(20,120,200,400),hKing);
				GUI.Box (new Rect (0,Screen.height - 250,600,250), dialog);	
				GUI.DrawTexture(new Rect(520,530,37,32),arrowHead);
				break;
			case 9:
				GUI.DrawTexture(new Rect(630,150,140,300),hPrince);
				GUI.Box (new Rect (Screen.width - 600,Screen.height - 250,600,250), dialog);
				GUI.DrawTexture(new Rect(720, 530,37,32),arrowHead);
				break;
			case 10:
				GUI.DrawTexture(new Rect(20,120,200,400),hKing);
				GUI.Box (new Rect (0,Screen.height - 250,600,250), dialog);	
				GUI.DrawTexture(new Rect(520,530,37,32),arrowHead);
				break;
			case 11:
				GUI.DrawTexture(new Rect(630,150,140,300),hPrince);
				GUI.Box (new Rect (Screen.width - 600,Screen.height - 250,600,250), dialog);
				GUI.DrawTexture(new Rect(720, 530,37,32),arrowHead);
				break;
			case 12:
				GUI.DrawTexture(new Rect(20,120,200,400),hSoldier);
				GUI.Box (new Rect (0,Screen.height - 250,600,250), dialog);	
				GUI.DrawTexture(new Rect(520,530,45,32),arrowHead);
				break;
			case 13:
				GUI.DrawTexture(new Rect(20,120,200,400),hKing);
				GUI.Box (new Rect (0,Screen.height - 250,600,250), dialog);	
				GUI.DrawTexture(new Rect(520,530,37,32),arrowHead);
				break;
			case 14:
				GUI.DrawTexture(new Rect(630,150,140,300),hPrince);
				GUI.Box (new Rect (Screen.width - 600,Screen.height - 250,600,250), dialog);
				GUI.DrawTexture(new Rect(720, 530,37,32),arrowHead);
				break;
			case 15:
				GUI.DrawTexture(new Rect(20,120,200,400),hKing);
				GUI.Box (new Rect (0,Screen.height - 250,600,250), dialog);	
				GUI.DrawTexture(new Rect(520,530,37,32),arrowHead);
				break;
			case 16:
				GUI.Box (new Rect (100,20,600,550), dialog );	
				GUI.DrawTexture(new Rect(610,470,37,32),arrowHead);
				break;
			case 17:
				GUI.DrawTexture(new Rect(20,120,200,400),fatMerchant);
				GUI.Box (new Rect (0,Screen.height - 250,600,250), dialog);	
				GUI.DrawTexture(new Rect(520,530,37,32),arrowHead);
				break;
			case 18:
				GUI.DrawTexture(new Rect(630,150,140,300),hPrince);
				GUI.Box (new Rect (Screen.width - 600,Screen.height - 250,600,250), dialog);
				GUI.DrawTexture(new Rect(720, 530,37,32),arrowHead);
				break;
			case 19:
				GUI.DrawTexture(new Rect(20,120,200,400),fatMerchant);
				GUI.Box (new Rect (0,Screen.height - 250,600,250), dialog);	
				GUI.DrawTexture(new Rect(520,530,37,32),arrowHead);
				break;
			case 20:
				GUI.DrawTexture(new Rect(630,150,140,300),hPrince);
				GUI.Box (new Rect (Screen.width - 600,Screen.height - 250,600,250), dialog);
				GUI.DrawTexture(new Rect(720, 530,37,32),arrowHead);
				break;
			case 21:
				GUI.Box (new Rect (100,20,600,550), dialog );	
				GUI.DrawTexture(new Rect(610,470,37,32),arrowHead);
				break;
			default:
                Debug.Log("pig");
                break;  
			}
		
		}
	}

