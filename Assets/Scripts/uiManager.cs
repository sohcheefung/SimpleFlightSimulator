using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class uiManager : MonoBehaviour {

    public static bool gameIsPaused = false;

	public GameObject play;
	public GameObject instructions;
	public GameObject menu;
	public GameObject exit;
	public GameObject pausePanel;
	
	// Use this for initialization
	void Awake()
	{

	
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void Pause()
	{
			if (gameIsPaused)
			{ 	
					Resume();
			}else
			{
					pauseGame();
			}
	}


	public void Play(){
		Application.LoadLevel ("Level1");
   }

	public void main(){
		Application.LoadLevel ("menu");
	}
	
	public void instruction(){
		Application.LoadLevel ("instructions");
	}
	
	public void pauseGame(){
		pausePanel.SetActive(true);
		Time.timeScale = 0f;
		gameIsPaused = true;
	}
	
	public void Resume(){
		pausePanel.SetActive(false);
		Time.timeScale = 1f;
		gameIsPaused = false;
	}
	
	public void quit(){
		Application.Quit ();
	}

}