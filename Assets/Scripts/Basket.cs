using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Basket : MonoBehaviour {

	private	int score=0;

	public Text scoreBoard;
	/// <summary>
	/// Awake is called when the script instance is being loaded.
	/// </summary>
	void Awake()
	{
		scoreBoard.text=score.ToString();
	}
	/// <summary>
	/// OnCollisionEnter is called when this collider/rigidbody has begun
	/// touching another rigidbody/collider.
	/// </summary>
	/// <param name="other">The Collision data associated with this collision.</param>
	void OnCollisionEnter(Collision other)
	{
		if(other.gameObject.CompareTag("Ball"))
		{
			score++;
			scoreBoard.text=score.ToString();
			//other.gameObject.GetComponent<BallBehaviour>().BallReset();
		}
	}

	/// <summary>
	/// OnTriggerEnter is called when the Collider other enters the trigger.
	/// </summary>
	/// <param name="other">The other Collider involved in this collision.</param>
	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.CompareTag("Ball"))
		{
			score++;
			scoreBoard.text=score.ToString();
			//other.gameObject.GetComponent<BallBehaviour>().BallReset();
		}
	}

	/// <summary>
	/// OnCollisionExit is called when this collider/rigidbody has
	/// stopped touching another rigidbody/collider.
	/// </summary>
	/// <param name="other">The Collision data associated with this collision.</param>
	void OnCollisionExit(Collision other)
	{
		//ball reset
	}
}
