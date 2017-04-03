using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    
    public void dineInTakeOutButton(string option){
        if(option == "dineIn"){
            GameManager.gManager.order.setDiningOption(true);
        }
        else{
            GameManager.gManager.order.setDiningOption(false);
        }
        //change menu
    }

	public void addItemToOrderButton(string item){
		switch (item) {
		case "drink_water":
			GameManager.gManager.order.waters++;
			break;
		case "drink_coke":
			GameManager.gManager.order.cokes++;
			break;
		case "drink_fanta":
			GameManager.gManager.order.fantas++;
			break;
		case "drink_rootBeer":
			GameManager.gManager.order.rootBeers++;
			break;
		case "drink_sprite":
			GameManager.gManager.order.sprites++;
			break;
		case "drink_drPepper":
			GameManager.gManager.order.drPeppers++;
			break;
		case "burger_hamburger":
			GameManager.gManager.order.hamburger++;
			break;
		case "burger_cheeseburger":
			GameManager.gManager.order.cheeseburger++;
			break;
		case "burger_baconBurger":
			GameManager.gManager.order.baconBurger++;
			break;
		case "burger_chickenBurger":
			GameManager.gManager.order.chickenBurger++;
			break;
		case "burger_customBurger":
			GameManager.gManager.order.addCustomBurger();
			break;
		case "side_fries":
			GameManager.gManager.order.fries++;
			break;
		case "side_onionRings":
			GameManager.gManager.order.onionRings++;
			break;
		case "side_iceCream":
			GameManager.gManager.order.iceCream++;
			break;
		}
	}

	public void removeItemFromOrderButton(string item){
		switch (item) {
		case "drink_water":
			GameManager.gManager.order.waters--;
			break;
		case "drink_coke":
			GameManager.gManager.order.cokes--;
			break;
		case "drink_fanta":
			GameManager.gManager.order.fantas--;
			break;
		case "drink_rootBeer":
			GameManager.gManager.order.rootBeers--;
			break;
		case "drink_sprite":
			GameManager.gManager.order.sprites--;
			break;
		case "drink_drPepper":
			GameManager.gManager.order.drPeppers--;
			break;
		case "burger_hamburger":
			GameManager.gManager.order.hamburger--;
			break;
		case "burger_cheeseburger":
			GameManager.gManager.order.cheeseburger--;
			break;
		case "burger_baconBurger":
			GameManager.gManager.order.baconBurger--;
			break;
		case "burger_chickenBurger":
			GameManager.gManager.order.chickenBurger--;
			break;
		case "side_fries":
			GameManager.gManager.order.fries--;
			break;
		case "side_onionRings":
			GameManager.gManager.order.onionRings--;
			break;
		case "side_iceCream":
			GameManager.gManager.order.iceCream--;
			break;
		}
	}

	public void removeCustomBurger(int number)
	{
		GameManager.gManager.order.removeCustomBurger(number);
	}

	public void checkOutButton(){

	}
		
}
