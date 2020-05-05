using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class levelScript : MonoBehaviour {

	public Canvas levelMenu;
	public Button Back2;
	public Button level1;
	public Canvas stars;





	// Use this for initialization
	void Start () {

		stars = stars.GetComponent<Canvas> ();
		levelMenu = levelMenu.GetComponent<Canvas> ();
		levelMenu.enabled = false;
		stars.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void goback2()
	{
        SceneManager.LoadScene("2");
		//Application.LoadLevel(2);
	}
	public void level1click()
	{
		levelMenu.enabled = true;
	}
	public void levelexit()
	{
		levelMenu.enabled = false;
	}

    public void enterGameplay()
    {
        SceneManager.LoadScene("SalmonPrep");
    }
}
