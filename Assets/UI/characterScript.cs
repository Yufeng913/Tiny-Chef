using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class characterScript : MonoBehaviour {

	public Canvas chefMenu;
	public Canvas yesno;

	//chef slecect buttons
	public Button TristanText;
	public Button MaiText;
	public Button DavidText;
	public Button YufengText;
	public Button Back1;

	// Use this for initialization
	void Start () {
	
		//chef select
		chefMenu = chefMenu.GetComponent<Canvas> ();
		yesno = yesno.GetComponent<Canvas> ();

		//chef select//
		TristanText = TristanText.GetComponent<Button> ();
		MaiText = MaiText.GetComponent<Button> ();
		DavidText = DavidText.GetComponent<Button> ();
		YufengText = YufengText.GetComponent<Button> ();
		Back1 = Back1.GetComponent<Button> ();
		/////
		//chef 
		yesno.enabled = false;

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void ChefCancel()
	{
		TristanText.enabled = true;
		DavidText.enabled = true;
		MaiText.enabled = true;
		YufengText.enabled = true;
		yesno.enabled = false;
	}

	public void Levelselect()
	{
        SceneManager.LoadScene("4");
        // Application.LoadLevel("4");
	}

	public void goback()
	{
        SceneManager.LoadScene("1");
        // Application.LoadLevel("1");
	}
	public void ChefPress()
	{
		TristanText.enabled = false;
		DavidText.enabled = false;
		MaiText.enabled = false;
		YufengText.enabled = false;
		yesno.enabled = true;
	}
}
