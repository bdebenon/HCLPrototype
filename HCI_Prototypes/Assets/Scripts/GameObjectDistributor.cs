using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectDistributor : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GameManager.gManager.mainMenu = GameObject.Find("Menu - Main");
		GameManager.gManager.burgerMenu = GameObject.Find("Menu - Burger");
		GameManager.gManager.drinksMenu = GameObject.Find("Menu - Drinks");
		GameManager.gManager.sidesMenu = GameObject.Find("Menu - Sides");
		GameManager.gManager.viewMenu = GameObject.Find("Menu - View Order");
		GameManager.gManager.checkoutMenu = GameObject.Find("Menu - Checkout");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
