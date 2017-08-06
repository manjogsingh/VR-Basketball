using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviour : MonoBehaviour {

	private Rigidbody rb;

	public Transform ballPortal;
	/// <summary>
	/// Start is called on the frame when a script is enabled just before
	/// any of the Update methods is called the first time.
	/// </summary>
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

	/// <summary>
	/// OnCollisionEnter is called when this collider/rigidbody has begun
	/// touching another rigidbody/collider.
	/// </summary>
	/// <param name="other">The Collision data associated with this collision.</param>
	void OnCollisionEnter(Collision other)
	{
		if(other.gameObject.CompareTag("Null Space"))
		{
			BallReset();
		}
	}
}
