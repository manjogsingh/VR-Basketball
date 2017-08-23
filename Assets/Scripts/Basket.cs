using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Basket : MonoBehaviour
{

    public static int score = 0;
    public Text scoreBoard;

    void Awake()
    {
        scoreBoard.text = score.ToString();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            if (Timer.timeLeft > 0)
            {
                score++;
                scoreBoard.text = score.ToString();
            }
            //other.gameObject.GetComponent<BallBehaviour>().BallReset();
        }
    }

    void OnCollisionExit(Collision other)
    {
        //ball reset
    }
}
