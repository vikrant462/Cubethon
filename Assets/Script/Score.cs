using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour 
{

	public Transform player;
	public Text scoreText;
	void Update ()
	{
		scoreText.text=(player.position.z+(41.84)).ToString("0");
	}
}
