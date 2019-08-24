using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour 
{
	//This is refrence to the Rigidbody component called "rb"
	public Rigidbody rb;
	public float forwardForce=2000f;
	public float sidewaysForce=500f;
	// Use this for initialization
	void Start () 
	{
		//rb.useGravity=true;
		//rb.AddForce(0,200,500);
		
	}
		// Update is called once per frame
		//We marked this as "Fixed"Update because we
		//are using it to mess with physics.
	void FixedUpdate () 
	{
		//Add a forwardForce of 2000 on z-axis
		rb.AddForce(0,0,forwardForce*Time.deltaTime);
		
		if( Input.GetKey("d"))
		{
			rb.AddForce(sidewaysForce*Time.deltaTime,0,0,ForceMode.VelocityChange);
		}
		
		if( Input.GetKey("a"))
		{
			rb.AddForce(-sidewaysForce*Time.deltaTime,0,0,ForceMode.VelocityChange);
		}
		
		if(rb.position.y < -1f)
		{
			FindObjectOfType<GameManager>().EndGame();
		}
	}
}
