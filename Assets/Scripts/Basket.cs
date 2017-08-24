using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Basket : MonoBehaviour
{
    public Text scoreBoard;
    public bool isRed;
    
    void Start()
    {
        scoreBoard.text = "0";
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            if (Timer.timeLeft > 0)
            {
                if(isRed)
                {
                    ScoreHandler.scoreRed++;
                    scoreBoard.text = ScoreHandler.scoreRed.ToString();
                }
                else
                {
                    ScoreHandler.scoreBlue++;
                    scoreBoard.text = ScoreHandler.scoreBlue.ToString();
                }                
            }
        }
    }
}
