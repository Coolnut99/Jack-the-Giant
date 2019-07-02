using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour {

	[SerializeField]
	private Button musicBtn;

	[SerializeField]
	private Sprite[] musicIcons;

	// Use this for initialization
	void Start () {
		CheckToPlayTheMusic();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void CheckToPlayTheMusic()
	{
		if(GamePreferences.GetMusicState() == 1)
		{
			MusicController.instance.PlayMusic(true);
			musicBtn.image.sprite = musicIcons[1];

		}
		else
		{
			MusicController.instance.PlayMusic(false);
			musicBtn.image.sprite = musicIcons[0];
		}

	}



	public void StartGame()
	{
		GameManager.instance.gameStartedFromMainMenu = true;
		//Application.LoadLevel("Gameplay");
		SceneFader.instance.LoadLevel("Gameplay");
	}

	public void HighScoreMenu()
	{
		Application.LoadLevel("HighscoreScene");
	}

	public void OptionsMenu()
	{
		Application.LoadLevel("Options");
	}

	public void QuitGame()
	{
		Application.Quit();
	}

	public void MusicButton()
	{
		if(GamePreferences.GetMusicState() == 0)
		{
			GamePreferences.SetMusicState(1);
			MusicController.instance.PlayMusic(true);
			musicBtn.image.sprite = musicIcons[1];
		}
		else if (GamePreferences.GetMusicState() == 1)
		{
			GamePreferences.SetMusicState(0);
			MusicController.instance.PlayMusic(false);
			musicBtn.image.sprite = musicIcons[0];
		}

	}

}
