using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameplayController : MonoBehaviour {

	public static GameplayController instance;

	[SerializeField]
	private Text scoreText, coinText, lifeText, gameOverScoreText, gameOverCoinText;

	[SerializeField]
	private GameObject pausePanel, gameOverPanel;

	[SerializeField]
	private GameObject readyButton;

	void Awake()
	{
		MakeInstance();
	}

	void MakeInstance()
	{
		if (instance == null)
		{
			instance = this;
		}

	}

	void Start()
	{
		Time.timeScale = 0f;
	}

	public void GameOverShowPanel(int finalScore, int finalCoinScore)
	{
		gameOverPanel.SetActive(true);
		gameOverScoreText.text = finalScore.ToString();
		gameOverCoinText.text = finalCoinScore.ToString();
		StartCoroutine("GameOverLoadMainMenu");
	}

	IEnumerator GameOverLoadMainMenu(){
		yield return new WaitForSeconds (3f);
		//Application.LoadLevel("Main Menu");
		SceneFader.instance.LoadLevel("Main Menu");
	}

	IEnumerator PlayerDiedRestart()
	{
		yield return new WaitForSeconds (1f);
		//Application.LoadLevel("Gameplay");
		SceneFader.instance.LoadLevel("Gameplay");
	}

	public void PlayerDiedRestartTheGame()
	{
		StartCoroutine("PlayerDiedRestart");
	}

	public void SetScore(int score)
	{
		scoreText.text = score.ToString();	
	}

	public void SetCoinScore(int coinScore)
	{
		coinText.text = "x" + coinScore;
	}

	public void SetLifeScore(int lifeScore)
	{
		lifeText.text = "x" + lifeScore;
	}

	public void PauseTheGame()
	{
		Time.timeScale = 0f;
		pausePanel.SetActive(true);
	}

	public void ResumeGame()
	{
		Time.timeScale = 1f;
		pausePanel.SetActive(false);
	}

	public void QuitGame()
	{
		Time.timeScale = 1f;
		//Application.LoadLevel("Main Menu");
		SceneFader.instance.LoadLevel("Main Menu");
	}

	public void StartTheGame()
	{
		Time.timeScale = 1f;
		readyButton.SetActive(false);
	}

}
