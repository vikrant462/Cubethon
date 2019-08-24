using UnityEngine;

public class PlayerCollision : MonoBehaviour 
{
	public PlayerMovement movement;//A refrence to our player movement script
	
	//This function runs when we hit another object.
	//we get information about the collision and call it "collisionInfo".
	void OnCollisionEnter(Collision collisionInfo)
	{
		//Debug.Log(collisionInfo.collider.name);
		
		//We check if the object we collide with has a tag called "Obstacle".
		if(collisionInfo.collider.tag=="Obstacle")
		{
			//Debug.Log("We hit an Obstacle!");
			movement.enabled=false;//Disable the players movement.
			FindObjectOfType<GameManager>().EndGame();
		}
	}
}