using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour 
{
    public float restartDelay=2f;
	
	public GameObject completeLevelUI;
	
	public void CompleteLevel()
	{
		//Debug.Log("Level Won!");
		completeLevelUI.SetActive(true);
	}
	
	public void EndGame()
	{
		Debug.Log("Game Over");
		Invoke("Restart",restartDelay);
	}
	
	void Restart()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
}
