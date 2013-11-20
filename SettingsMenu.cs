using UnityEngine;
using System.Collections;

public class SettingsMenu : MonoBehaviour {

	#region Variables
	public GUISkin skin;
	public GUIStyle selectionGridStyle;
	public int menuChoice = 0;
	public bool 
		isAudioLoud = false,
		isMusicLoud = false;
	public float 
		musicVolume,
		audioVolume;
	public GameObject mainMenu;

	private Rect menuBox;
	private int menuID = 1;
	private string[] menuChoices = {"reset game", "music", "audio", "back"};
	#endregion
	
	/**************************************************************************
     * This region is used for getters and setters to clamp/validate values
     * passed to the parameters. Every important public values must be clamped
     *************************************************************************/
	#region Clamping
	private int _menuChoice {
		get {
			return menuChoice = Mathf.Clamp(menuChoice, 0, menuChoices.Length - 1);
		}
		set {
			menuChoice = Mathf.Clamp(value, 0, menuChoices.Length - 1);
		}
	}
	private float _musicVolume {
		get {
			return musicVolume = Mathf.Clamp(musicVolume, 0.0f, 100.0f);
		}
		set {
			musicVolume = Mathf.Clamp(value, 0.0f, 100.0f);
		}
	}
	private float _audioVolume {
		get {
			return audioVolume = Mathf.Clamp(audioVolume, 0.0f, 100.0f);
		}
		set {
			audioVolume = Mathf.Clamp(value, 0.0f, 100.0f);
		}
	}
	#endregion

	/* Use this for initialization */
	void Start () {
		menuBox = new Rect(Screen.width / 2 - 100, Screen.height / 2 - 150, 200, 300);

	}
	
	/* Update is called once per frame */
	void Update () {
		
		handleChangeSelection();
		handleMusicVolume();
		handleAudioVolume();
		handleBack();
	}

	void OnGUI() {
		GUI.skin = skin;
		menuBox = GUILayout.Window(menuID, menuBox, doMenu, "settings");

	}

	void handleBack(){
		if(menuChoices[_menuChoice] == "back") {
			if(Input.GetKeyDown(KeyCode.Return)){
				mainMenu.SetActive(true);
				this.gameObject.SetActive(false);
			}
		}
	}

	void handleMusicVolume(){
		if(menuChoices[_menuChoice] == "music") {
		   	if(Input.GetKey(KeyCode.RightArrow)){
				_musicVolume+=1;
			}
			else if(Input.GetKey(KeyCode.LeftArrow)){
				_musicVolume-=1;
			}
			else if(Input.GetKeyDown(KeyCode.Return)){
				isMusicLoud = !isMusicLoud;
			}
		}
	}
	
	void handleAudioVolume(){
		if(menuChoices[_menuChoice] == "audio") {
			if(Input.GetKey(KeyCode.RightArrow)){
				_audioVolume+=1;
			}
			else if(Input.GetKey(KeyCode.LeftArrow)){
				_audioVolume-=1;
			}
			else if(Input.GetKeyDown(KeyCode.Return)){
				isAudioLoud = !isAudioLoud;
			}
		}
	}

	void handleChangeSelection(){
		
		/*handles changes in selection*/
		if (Input.GetKeyDown(KeyCode.DownArrow)) {
			_menuChoice = _menuChoice + 1;
		}
		else if (Input.GetKeyDown(KeyCode.UpArrow)) {
			_menuChoice = _menuChoice - 1;
		}
	}

	void doMenu(int iD){
		GUILayout.Space(55);
		_menuChoice = GUILayout.SelectionGrid(_menuChoice, menuChoices, 1, selectionGridStyle);

		if(menuChoices[_menuChoice] == "music"){
			if(isMusicLoud == true) {
				musicVolume = GUI.HorizontalSlider(new Rect(50,158,98,20),musicVolume,0,100);
			}
			isMusicLoud = GUI.Toggle(new Rect(150,137,20,20),isMusicLoud,"");
		}
		else if(menuChoices[_menuChoice] == "audio") {
			if(isAudioLoud == true){
				audioVolume = GUI.HorizontalSlider(new Rect(50,188,98,20),audioVolume,0,100);
			}
			isAudioLoud = GUI.Toggle(new Rect(150,167,20,20),isAudioLoud,"");
		}
	}
}
