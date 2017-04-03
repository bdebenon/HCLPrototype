using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public static GameManager gManager = null;
    public Order order;

	public GameObject mainMenu;
	public GameObject burgerMenu;
	public GameObject drinksMenu;
	public GameObject sidesMenu;
	public GameObject viewMenu;
	public GameObject checkoutMenu;

	public ButtonManager bManager;

	// Use this for initialization
	void Start () {

		if (gManager == null) {
			gManager = this;
		} 
		else if (gManager != this) {
			Destroy (gameObject);
		}

		DontDestroyOnLoad (gameObject);

        order = new Order();
	}

	public void changeScene(string sceneName)
	{
		SceneManager.LoadScene (sceneName);
	}

	public void assignMenus()
	{
		mainMenu = GameObject.Find("Menu - Main");
		burgerMenu = GameObject.Find("Menu - Burger");
		drinksMenu = GameObject.Find("Menu - Drinks");
		sidesMenu = GameObject.Find("Menu - Sides");
		viewMenu = GameObject.Find("Menu - View Order");
		checkoutMenu = GameObject.Find("Menu - Checkout");
	}

	// Update is called once per frame
	void Update () {
		
	}
}
