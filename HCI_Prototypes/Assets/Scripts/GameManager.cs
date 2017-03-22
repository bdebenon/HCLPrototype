using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public GameManager gManager = null;

	// Use this for initialization
	void Start () {

		if (gManager == null) {
			gManager = this;
		} 
		else if (gManager != this) {
			Destroy (gameObject);
		}

		DontDestroyOnLoad (gameObject);

	}

	public void changeScene(string sceneName)
	{
		SceneManager.LoadScene (sceneName);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
