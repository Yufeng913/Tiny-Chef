using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
using Leap;

public class Gestures : MonoBehaviour
{
    Controller controller;
    public GameObject blockOne;
    public GameObject blockTwo;
	public GameObject blockThree;
	public GameObject blockFour;
	public GameObject blockFive;
	public GameObject blockSix;
	public GameObject blockSeven;
	public GameObject blockEight;

    public GameObject CUblockFive;
    public GameObject CUblockSix;
    public GameObject CUblockSeven;
    public GameObject CUblockEight;

    public GameObject plate;

	//public bool translate;
	public int counter = 0;
	//public int a = 0;

    // Use this for initialization
    void Start()
    {
        controller = new Controller();
        controller.EnableGesture(Gesture.GestureType.TYPESWIPE);
        controller.Config.SetFloat("Gesture.Swipe.MinLength", 200.0f);
        controller.Config.SetFloat("Gesture.SwipeMinVeolcity", 750.0f);
        controller.Config.Save();

        //blockOne.SetActive(true);
        //blockTwo.SetActive(true);

    }

    // Update is called once per frame
    void Update()
	{
		Frame frame = controller.Frame ();
		GestureList gestures = frame.Gestures ();
		if (counter < 90) {
			for (int i = 0; i < gestures.Count; i++) {
				Gesture gesture = gestures [i];
				if (gesture.Type == Gesture.GestureType.TYPESWIPE) {
					SwipeGesture Swipe = new SwipeGesture (gesture);
					Vector swipeDirection = Swipe.Direction;
					if (swipeDirection.y > 0 || swipeDirection.y < 0) {
						Debug.Log ("Swiped");
						//translate = true;
				
						counter++;
						/*	
						if (counter <= 40 && counter >= 20)
							a = 1;

						if (counter <= 80 && counter >= 60)
							a = 2;

						if (counter <= 140 && counter >= 110)
							a = 3;*/

						if (counter <= 40 && counter >= 0) {
							blockTwo.transform.position = blockOne.transform.position;
							blockOne.SetActive (false);
						}

						if (counter <= 80 && counter >= 41) {
							blockThree.transform.position = blockTwo.transform.position;
							blockFour.transform.position = blockTwo.transform.position;
							blockTwo.SetActive (false);
						}

						if (counter >= 81) {
							blockFive.transform.position = blockThree.transform.position;
							blockSix.transform.position = blockThree.transform.position;
							blockSeven.transform.position = blockFour.transform.position;
							blockEight.transform.position = blockFour.transform.position;
							blockThree.SetActive (false);
							blockFour.SetActive (false);
						}
					}

					if (blockFive.transform.position == plate.transform.position || blockSix.transform.position == plate.transform.position || blockSeven.transform.position == plate.transform.position || blockEight.transform.position == plate.transform.position) {
						SceneManager.LoadScene ("testscene");
					}
					
				}
			}
		}

        
		if (blockFive == null && blockSix == null && blockSeven == null && blockEight == null)
		{
			SceneManager.LoadScene("CuPrep");
		}

        if (CUblockFive == null && CUblockSix == null && CUblockSeven == null && CUblockEight == null)
        {
            SceneManager.LoadScene("resultsscene");
        }

    }
}