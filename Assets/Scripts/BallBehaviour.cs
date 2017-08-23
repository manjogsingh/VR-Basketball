using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviour : MonoBehaviour {

	private Rigidbody rb;

	public Transform ballPortal;
	public GameObject endCanvas;
	void Start()
	{
		rb=GetComponent<Rigidbody>();
	}
	public void BallReset()
	{
		transform.position=ballPortal.position;
		rb.angularVelocity=Vector3.zero;
		rb.velocity=Vector3.zero;
	}

	void OnCollisionEnter(Collision other)
	{
		if(other.gameObject.CompareTag("Null Space"))
		{
			BallReset();
		}
	}

	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.name.Equals("Restart"))
		{
			endCanvas.SetActive(false);
			Timer.timeLeft=90f;
		}
		else if(other.gameObject.name.Equals("Exit"))
		{
			//exit
		}
	}
}
