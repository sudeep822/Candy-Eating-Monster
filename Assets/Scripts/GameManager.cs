﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //using name
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject livesHolder;
    public GameObject gameOverPanel;

    int score = 0;
    int lives = 3;
    bool gameOver = false;

    public Text scoreText;

    private void Awake()
    {
    	instance=this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void IncrementScore()
    {
    	if(!gameOver)

    		{
    	    	score++;
    	    	scoreText.text = score.ToString();
    	   //print(score);
    	    }
    }

    public void DecrementLife()
    {
    	if(lives > 0)
    	{
    		lives--;
    		//print(lives);
    		livesHolder.transform.GetChild(lives).gameObject.SetActive(false);

    	}
    	if(lives <= 0)
    	{
    		gameOver = true;
    		GameOver();
    	}
    }

    public void GameOver()
    { 
    	CandySpawner.instance.StopSpawningCandies();
    	GameObject.Find("Player").GetComponent<PlayerCotroller>().canMove = false;

    	gameOverPanel.SetActive(true);
    	print("game over");
    }

    public void Restart()
    {
    	SceneManager.LoadScene("Game"); //to load game scene
    }

    public void BackToMenu()
    {
    	SceneManager.LoadScene("Menu");
    }
}
