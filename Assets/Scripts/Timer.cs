﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public static float timeLeft=90f;
    public Text timer;
    public GameObject endGameCanvas;
	public Text endScore;
    void Start()
    {
        timer.text = timeLeft.ToString();
    }
    // Update is called once per frame
    void Update()
    {
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            timeLeft = Mathf.Round(timeLeft * 100f) / 100f;
            timer.text = timeLeft.ToString().Replace('.', ':');
        }
        else if (timeLeft < 0)
        {
			timer.text="00:00";
            endGameCanvas.SetActive(true);
            endScore.text = Basket.score.ToString();
        }
    }
}