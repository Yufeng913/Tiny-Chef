using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;


public class menuScript : MonoBehaviour	{

	public Canvas quitMenu;
	public Canvas optionsMenu;

	//main menu buttons
	public Button startText;
	public Button exitText;
	public Button optionsText;

	void Start () {

		//main menu
		optionsMenu = optionsMenu.GetComponent<Canvas> ();
		quitMenu = quitMenu.GetComponent<Canvas> ();

		//main menu//
		startText = startText.GetComponent<Button> ();
		exitText = exitText.GetComponent<Button> ();
		optionsText = optionsText.GetComponent<Button> ();
		////////////

		//turn off pop-ups
		//main
		quitMenu.enabled = false;
		optionsMenu.enabled = false;

	}

	public void ExitPress()
	{
		quitMenu.enabled = true;
		startText.enabled = false;
		exitText.enabled = false;
		optionsText.enabled = false;
	}

	public void OptionPress()
	{
		optionsMenu.enabled = true;
		startText.enabled = false;
		exitText.enabled = false;
		optionsText.enabled = false;
	}

	public void Cancel()
	{
		startText.enabled = true;
		exitText.enabled = true;
		optionsText.enabled = true;
		optionsMenu.enabled = false;
	}

	public void Save()
	{		
		startText.enabled = true;
		exitText.enabled = true;
		optionsText.enabled = true;
		optionsMenu.enabled = false;
	}

	public void NoPress()
	{
		startText.enabled = true;
		exitText.enabled = true;
		optionsText.enabled = true;
		quitMenu.enabled = false;
	}

	//from start -> chef selection
	public void StartGame()
	{
        SceneManager.LoadScene("2");
        // Application.LoadLevel("2");
	}
		
	public void ExitGame()
	{
		Application.Quit ();
	}


}











/*
{
	
	public Canvas panelOptionsCanvas;
	public Canvas optionsOpen;
	public Canvas quitMenu;

	public Canvas optionsMenu;
	public Button startText;
	public Button exitText;

	public Canvas Options;
	public Canvas ContinuePlay;


	// Use this for initialization
	void Start()
	{
		
		panelOptionsCanvas = panelOptionsCanvas.GetComponent<Canvas> ();
		panelOptionsCanvas.enabled = false;
		optionsOpen.enabled = false;


		optionsMenu = optionsMenu.GetComponent<Canvas>();
		optionsMenu.enabled = false;

		Options = Options.GetComponent<Canvas>();
		quitMenu.enabled = false;
		Options.enabled = false;
		ContinuePlay.enabled = false;


	}

	public void Level1Play()
	{
		Application.LoadLevel (6);
	}

	public void Level1() //Level 1 Window
	{
		Application.LoadLevel (5);
	}

	public void StartLvlSel() //Level Selection
	{
		
		Application.LoadLevel (4);
	}

	public void Chef1() //Chef 1 Window
	{
		Application.LoadLevel (3);
	}

	public void StartChefSel() //Chef Selection
	{
		Application.LoadLevel (2);
	}

	public void OptionsPress() //Options Window
	{
		make window popup not loading new scene
		Application.LoadLevel (1);
		
		if (optionsOpen == false)
		{
			optionsOpen = true;
			panelOptionsCanvas.enabled = true;
		}

		if (optionsOpen == true)
		{
			optionsOpen = false;
			panelOptionsCanvas.enabled = false;
		}
	}

	public void StartMenu() //Main Menu
	{
		Application.LoadLevel (0);
		//Options.enabled = false;
	}

	public void openWebpage()
	{
		Application.OpenURL("http://www.anotherjuanstudios.com"); // Current placeholder
	}

	public void ExitGame()
	{
		Application.Quit ();
	}

}
*/