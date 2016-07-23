using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class GameController : MonoBehaviour {

    public GUIText missText;
    public GUIText perfectText;
    public GUIText greatText;
    public GUIText goodText;
    public GUIText instructions;
    public GUIText scoreText;
    public GUIText scoreCountText;
    public GUIText accuracyText;
    
    private bool gameStart;
    private AudioSource audioSource;

    private int perfectCount;
    private int greatCount;
    private int goodCount;
    private int missCount;
    private int score;

    private double accuracy;
    private int accuracyCount;

    IEnumerator Stall()
    {
        yield return new WaitWhile(() => !gameStart);
        instructions.text = "";
        yield return new WaitForSeconds(0.88f);
        audioSource = GetComponent<AudioSource>();
        audioSource.Play();
    }

    void Start()
    {
        gameStart = false;

        accuracy = 0;
        accuracyCount = 0;

        score = 0;
        perfectCount = 0;
        greatCount = 0;
        goodCount = 0;
        missCount = 0;

        missText.text = "Miss: 0";
        perfectText.text = "Perfect: 0";
        greatText.text = "Great: 0";
        goodText.text = "Good: 0";
        scoreText.text = "SCORE";
        scoreCountText.text = "";
        accuracyText.text = "";

        StartCoroutine(Stall());                
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            gameStart = true;
        }
    }

    public void UpdatePerfect()
    {
        accuracy += 100;
        accuracyCount++;

        score += 300;        
        perfectCount++;
        perfectText.text = "Perfect: " + perfectCount;
    }

    public void UpdateGreat()
    {
        accuracy += 66.66;
        accuracyCount++;

        score += 200;
        greatCount++;        
        greatText.text = "Great: " + greatCount;
    }

    public void UpdateGood()
    {
        accuracy += 33.33;
        accuracyCount++;

        score += 50;
        goodCount++;
        goodText.text = "Good: " + goodCount;
    }

    public void UpdateMiss()
    {
        accuracyCount++;

        missCount++;
        missText.text = "Miss: " + missCount;
    }

    public void UpdateScore()
    {
        scoreCountText.text = score.ToString();
    }

    public void UpdateAccuracy()
    {
        accuracyText.text = Math.Round((accuracy / accuracyCount), 2).ToString() + "%";
    }
}
