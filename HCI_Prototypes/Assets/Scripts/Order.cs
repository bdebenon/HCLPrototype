using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class Order {

	public int customBurgerNumber = 0;

    // true = dine in. false = take out.
    public bool diningOption = true;

	//Drinks
	public int waters = 0;
	public int cokes = 0;
	public int sprites = 0;
	public int fantas = 0;
	public int rootBeers = 0;
	public int drPeppers = 0;
    
	//Burgers
	public int hamburger = 0;
	public int cheeseburger = 0;
	public int baconBurger = 0;
	public int chickenBurger = 0;
	public Dictionary<int, CustomBurger> customBurgers;
    
	//Sides
	public int fries = 0;
	public int onionRings = 0;
	public int iceCream = 0;

    //Cost
    double costWater = 1.00;
    double costSoda = 2.00;
    double costHamburger = 4.50;
    double costCheeseburger = 5.00;
    double costBaconburger = 6.50;
    double costChickenburger = 5.00;
    double costFries = 2.50;
    double costOnionRings = 3.00;
    double costIceCream = 2.00;
    double subTotal = 0;
    double tax = 0;
    double Total = 0;
    double taxRate = 0.0825;
    
    public void addCustomBurger()
    {
		CustomBurger newBurger = new CustomBurger ();
		customBurgers.Add(customBurgerNumber, newBurger);
		customBurgerNumber++;
    }

	public void removeCustomBurger(int itemPosition)
	{
		customBurgers.Remove(itemPosition);
        //Maybe --custonBurgerNumber?
	}
    
    public void setDiningOption(bool _option){
        diningOption = _option;
    }
    
    void checkOut(){
		customBurgers.Clear();
        subTotal = 0;
		customBurgerNumber = 0;
    }

	public void updateTotalCost()
	{
		double cost = 0;

		cost += waters * costWater;
		cost += cokes * costSoda;
		cost += sprites * costSoda;
		cost += fantas * costSoda;
		cost += rootBeers * costSoda;
		cost += drPeppers * costSoda;
		cost += hamburger * costHamburger;
		cost += cheeseburger * costCheeseburger;
		cost += baconBurger * costBaconburger;
		cost += chickenBurger * costChickenburger;
		cost += fries * costFries;
		cost += onionRings * costOnionRings;
		cost += iceCream * costIceCream;

		//foreach (KeyValuePair<int, CustomBurger> cb in customBurgers)
		//{
		//	cost += cb.Value.price;
		//}

        subTotal = cost;
        tax = subTotal * taxRate;
        Total = subTotal + tax;
	}
    public string getOrderInformation()
    {
        string orderInfo = "";
        updateTotalCost();
        if(waters > 0)
        {
            orderInfo = orderInfo + "Waters: " + waters.ToString() + " * " + costWater.ToString("C") + " = " + (waters * costWater).ToString("C") + "\n";

        }
        if (cokes > 0)
        {
            orderInfo = orderInfo + "Cokes: " + cokes.ToString() + " * " + costSoda.ToString("C") + " = " + (cokes * costSoda).ToString("C") + "\n";
        }
        if (sprites > 0)
        {
            orderInfo = orderInfo + "Sprites: " + sprites.ToString() + " * " + costSoda.ToString("C") + " = " + (sprites * costSoda).ToString("C") + "\n";
        }
        if (fantas > 0)
        {
            orderInfo = orderInfo + "Fantas: " + fantas.ToString() + " * " + costSoda.ToString("C") + " = " + (fantas * costSoda).ToString("C") + "\n";
        }
        if (rootBeers > 0)
        {
            orderInfo = orderInfo + "Root Beer: " + rootBeers.ToString() + " * " + costSoda.ToString("C") + " = " + (rootBeers * costSoda).ToString("C") + "\n";
        }
        if (drPeppers > 0)
        {
            orderInfo = orderInfo + "Dr Pepper: " + drPeppers.ToString() + " * " + costSoda.ToString("C") + " = " + (drPeppers * costSoda).ToString("C") + "\n";
        }
        if (hamburger > 0)
        {
            orderInfo = orderInfo + "Hamburgers: " + hamburger.ToString() + " * " + costHamburger.ToString("C") + " = " + (hamburger * costHamburger).ToString("C") + "\n";
        }
        if (cheeseburger > 0)
        {
            orderInfo = orderInfo + "Cheeseburgers: " + cheeseburger.ToString() + " * " + costCheeseburger.ToString("C") + " = " + (cheeseburger * costCheeseburger).ToString("C") + "\n";
        }
        if (baconBurger > 0)
        {
            orderInfo = orderInfo + "Bacon Burgers: " + baconBurger.ToString() + " * " + costBaconburger.ToString("C") + " = " + (baconBurger * costBaconburger).ToString("C") + "\n";
        }
        if (chickenBurger > 0)
        {
            orderInfo = orderInfo + "Chicken Burgers: " + chickenBurger.ToString() + " * " + costChickenburger.ToString("C") + " = " + (chickenBurger * costChickenburger).ToString("C") + "\n";
        }
        //CUSTOMBURGERS?
        if (fries > 0)
        {
            orderInfo = orderInfo + "French Fries: " + fries.ToString() + " * " + costFries.ToString("C") + " = " + (fries * costFries).ToString("C") + "\n";
        }
        if (onionRings > 0)
        {
            orderInfo = orderInfo + "Onion Rings: " + onionRings.ToString() + " * " + costOnionRings.ToString("C") + " = " + (onionRings * costOnionRings).ToString("C") + "\n";
        }
        if (iceCream > 0)
        {
            orderInfo = orderInfo + "Ice Cream: " + iceCream.ToString() + " * " + costIceCream.ToString("C") + " = " + (iceCream * costIceCream).ToString("C") + "\n";
        }
        orderInfo = orderInfo + "\nSubtotal: " + subTotal.ToString("C") + "\n";
        orderInfo = orderInfo + "Tax: " + subTotal.ToString("C") + " * "+ taxRate.ToString() + " = " +tax.ToString("C") + "\n";
        orderInfo = orderInfo + "\nTotal: " + Total.ToString("C") + "\n";
        //TOTALCOST
        return orderInfo;
    }
    public void updateOrder()
    {
        string orderInfo = getOrderInformation();
        GameManager.gManager.findGameObject("ViewOrderText").GetComponent<Text>().text = orderInfo;
        GameManager.gManager.findGameObject("CheckoutText").GetComponent<Text>().text = orderInfo;
    }
}
