
#region Namespaces
using UnityEngine;
using System.Collections;
using System.Xml;
#endregion

public class MainMenu : MonoBehaviour {

    #region Variables
    public GUISkin skin;
    public int menuChoice;
    public GUIStyle selectionGridStyle;
	public GameObject settingsMenu;

    private Rect menuBox;
    private int menuID = 0;
    private string[] menuChoices = { "new game", "options", "credits", "exit" };
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
    #endregion

    /* Use this for initialization*/
    void Start() {
        /* initialization for the menu Rect is done here due to the Screen width/height
         * being only visible when the game loads */
        menuBox = new Rect(Screen.width / 2 - 100, Screen.height / 2 - 150, 200, 300);
        
    }

    /* Update is called once per frame */
    void Update() {
        handleChangeSelection();
        handleSelectChoice();
    }

    void OnGUI() {
        GUI.skin = skin; 
        GUI.depth = 1;
        menuBox = GUI.Window(menuID, menuBox, doMenu, "main menu");
    }

    void handleSelectChoice() {
        if (Input.GetKeyDown(KeyCode.Return)) {
            /* these values are purposely using strings for case statements for 
             * readability purposes*/
            switch (menuChoices[_menuChoice]) {
                case "new game":
                    break;
                case "options":
				settingsMenu.SetActive(true);
				this.gameObject.SetActive(false);
                    break;
                case "credits":
                    break;
                case "exit":
                    Debug.Log("quiting");
                    Application.Quit();
                    break;
            }
        }
    }

    void handleChangeSelection() {

        /*handles changes in selection*/
        if (Input.GetKeyDown(KeyCode.DownArrow)) {
            _menuChoice = _menuChoice + 1;
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow)) {
            _menuChoice = _menuChoice - 1;
        }
    }

    void doMenu(int windowID) {
        GUILayout.BeginVertical();
        GUILayout.Space(55.0f);

        _menuChoice = GUILayout.SelectionGrid(_menuChoice, menuChoices, 1, selectionGridStyle);

        GUILayout.EndVertical();
    }
}
