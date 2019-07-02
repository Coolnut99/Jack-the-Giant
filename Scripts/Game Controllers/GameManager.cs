﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public static GameManager instance;

	[HideInInspector]
	public bool gameStartedFromMainMenu, gameRestartedAfterPlayerDied;

	[HideInInspector]
	public int score, coinScore, lifeScore;

	// Use this for initialization
	void Awake() {
		MakeSingleton();
	}
	void Start()
	{
		InitializeVariables();
	}

	void OnLevelWasLoaded()
	{
		if(Application.loadedLevelName == "Gameplay")
		{
			if(gameRestartedAfterPlayerDied)
			{
				GameplayController.instance.SetScore(score);
				GameplayController.instance.SetCoinScore(coinScore);
				GameplayController.instance.SetLifeScore(lifeScore);

				PlayerScore.scoreCount = score;
				PlayerScore.coinCount = coinScore;
				PlayerScore.lifeCount = lifeScore;
			}
			else if (gameStartedFromMainMenu)
			{
				PlayerScore.scoreCount = 0;
				PlayerScore.coinCount = 0;
				PlayerScore.lifeCount = 2;

				GameplayController.instance.SetScore(0);
				GameplayController.instance.SetCoinScore(0);
				GameplayController.instance.SetLifeScore(2);
				
			}
		}
	}

	void InitializeVariables()
	{
		if(!PlayerPrefs.HasKey("Game Initialized"))
		{
			GamePreferences.SetEasyDifficulty(0);
			GamePreferences.SetEasyDifficultyHighScore(0);
			GamePreferences.SetEasyDifficultyCoinScore(0);

			GamePreferences.SetMediumDifficulty(1);
			GamePreferences.SetMediumDifficultyHighScore(0);
			GamePreferences.SetMediumDifficultyCoinScore(0);

			GamePreferences.SetHardDifficulty(0);
			GamePreferences.SetHardDifficultyHighScore(0);
			GamePreferences.SetHardDifficultyCoinScore(0);

			GamePreferences.SetMusicState(0);

			PlayerPrefs.SetInt("Game Initialized", 1);

		}

	}
	
	void MakeSingleton()
	{
		if(instance != null)
		{
			Destroy(gameObject);
		} else {
			instance = this;
			DontDestroyOnLoad(gameObject);
		}
	}

	public void CheckGameStatus(int score, int coinScore, int lifeScore)
	{
		if (lifeScore < 0)
		{
			if(GamePreferences.GetEasyDifficulty() == 1)
			{
				int highScore = GamePreferences.GetEasyDifficultyHighScore();
				int coinHighScore = GamePreferences.GetEasyDifficultyCoinScore();

				if (highScore < score)
				{
					GamePreferences.SetEasyDifficultyHighScore(score);
				}

				if (coinHighScore < coinScore)
				{
					GamePreferences.SetEasyDifficultyCoinScore(coinScore);
				}

			}

			if(GamePreferences.GetMediumDifficulty() == 1)
			{
				int highScore = GamePreferences.GetMediumDifficultyHighScore();
				int coinHighScore = GamePreferences.GetMediumDifficultyCoinScore();

				if (highScore < score)
				{
					GamePreferences.SetMediumDifficultyHighScore(score);
				}

				if (coinHighScore < coinScore)
				{
					GamePreferences.SetMediumDifficultyCoinScore(coinScore);
				}

			}

			if(GamePreferences.GetHardDifficulty() == 1)
			{
				int highScore = GamePreferences.GetHardDifficultyHighScore();
				int coinHighScore = GamePreferences.GetHardDifficultyCoinScore();

				if (highScore < score)
				{
					GamePreferences.SetHardDifficultyHighScore(score);
				}

				if (coinHighScore < coinScore)
				{
					GamePreferences.SetHardDifficultyCoinScore(coinScore);
				}

			}

			gameStartedFromMainMenu = false;
			gameRestartedAfterPlayerDied = false;

			GameplayController.instance.GameOverShowPanel(score, coinScore);

		}
		else
		{
			this.score = score;
			this.coinScore = coinScore;
			this.lifeScore = lifeScore;

			GameplayController.instance.SetScore(score);
			GameplayController.instance.SetCoinScore(coinScore);
			GameplayController.instance.SetLifeScore(lifeScore);

			gameRestartedAfterPlayerDied = true;
			gameStartedFromMainMenu = false;

			GameplayController.instance.PlayerDiedRestartTheGame();

		}

	}
}
