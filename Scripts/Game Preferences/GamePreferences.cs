using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GamePreferences {

	public static string EasyDifficulty = "EasyDifficulty";
	public static string MediumDifficulty = "MediumDifficulty";
	public static string HardDifficulty = "HardDifficulty";

	public static string EasyDifficultyHighScore = "EasyDifficultyHighScore";
	public static string MediumDifficultyHighScore = "MediumDifficultyHighScore";
	public static string HardDifficultyHighScore = "HardDifficultyHighScore";

	public static string EasyDifficultyCoinScore = "EasyDifficultyCoinScore";
	public static string MediumDifficultyCoinScore = "MediumDifficultyCoinScore";
	public static string HardDifficultyCoinScore = "HardDifficultyCoinScore";

	public static string IsMusicOn = "IsMusicOn";

	//NOTE we are going to use integers to represent boolean variables

	//Get and set music
	public static int GetMusicState()
	{
		return PlayerPrefs.GetInt(GamePreferences.IsMusicOn);
	}

	public static void SetMusicState(int state)
	{
		PlayerPrefs.SetInt(GamePreferences.IsMusicOn, state);
	}


	//Get and set difficulty
	public static void SetEasyDifficulty(int difficulty)
	{
		PlayerPrefs.SetInt(GamePreferences.EasyDifficulty, difficulty);
	}

	public static int GetEasyDifficulty()
	{
		return PlayerPrefs.GetInt(GamePreferences.EasyDifficulty);
	}

	public static void SetMediumDifficulty(int difficulty)
	{
		PlayerPrefs.SetInt(GamePreferences.MediumDifficulty, difficulty);
	}

	public static int GetMediumDifficulty()
	{
		return PlayerPrefs.GetInt(GamePreferences.MediumDifficulty);
	}

	public static void SetHardDifficulty(int difficulty)
	{
		PlayerPrefs.SetInt(GamePreferences.HardDifficulty, difficulty);
	}

	public static int GetHardDifficulty()
	{
		return PlayerPrefs.GetInt(GamePreferences.HardDifficulty);
	}


	//Get and set high scores

	public static void SetEasyDifficultyHighScore(int score)
	{
		PlayerPrefs.SetInt(GamePreferences.EasyDifficultyHighScore, score);
	}

	public static int GetEasyDifficultyHighScore()
	{
		return PlayerPrefs.GetInt(GamePreferences.EasyDifficultyHighScore);
	}

	public static void SetMediumDifficultyHighScore(int score)
	{
		PlayerPrefs.SetInt(GamePreferences.MediumDifficultyHighScore, score);
	}

	public static int GetMediumDifficultyHighScore()
	{
		return PlayerPrefs.GetInt(GamePreferences.MediumDifficultyHighScore);
	}

	public static void SetHardDifficultyHighScore(int score)
	{
		PlayerPrefs.SetInt(GamePreferences.HardDifficultyHighScore, score);
	}

	public static int GetHardDifficultyHighScore()
	{
		return PlayerPrefs.GetInt(GamePreferences.HardDifficultyHighScore);
	}


	//Get and set high coin scores

	public static void SetEasyDifficultyCoinScore(int coinScore)
	{
		PlayerPrefs.SetInt(GamePreferences.EasyDifficultyCoinScore, coinScore);
	}

	public static int GetEasyDifficultyCoinScore()
	{
		return PlayerPrefs.GetInt(GamePreferences.EasyDifficultyCoinScore);
	}

	public static void SetMediumDifficultyCoinScore(int coinScore)
	{
		PlayerPrefs.SetInt(GamePreferences.MediumDifficultyCoinScore, coinScore);
	}

	public static int GetMediumDifficultyCoinScore()
	{
		return PlayerPrefs.GetInt(GamePreferences.MediumDifficultyCoinScore);
	}

	public static void SetHardDifficultyCoinScore(int coinScore)
	{
		PlayerPrefs.SetInt(GamePreferences.HardDifficultyCoinScore, coinScore);
	}

	public static int GetHardDifficultyCoinScore()
	{
		return PlayerPrefs.GetInt(GamePreferences.HardDifficultyCoinScore);
	}


}
