using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class guideBook : MonoBehaviour {

    public Canvas guideBookMenu;

    public Button guideBookMenuButton;
    public Button exitGuidebook;

	// Use this for initialization
	void Start () {

        guideBookMenu = guideBookMenu.GetComponent<Canvas>();
        exitGuidebook = exitGuidebook.GetComponent<Button>();
        guideBookMenuButton = guideBookMenuButton.GetComponent<Button>();

        guideBookMenu.enabled = false;
        exitGuidebook.enabled = false;
    }

    public void guidebookPress()
    {
        guideBookMenu.enabled = true;
        exitGuidebook.enabled = true;
    }

    public void cancelGuidebook()
    {
        guideBookMenu.enabled = false;
        exitGuidebook.enabled = false;
    }
	
}
