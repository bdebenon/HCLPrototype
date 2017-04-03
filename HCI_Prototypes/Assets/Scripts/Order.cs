using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    double totalCost = 0;
    
    public void addcustomBurger()
    {
		CustomBurger newBurger = new CustomBurger ();
		customBurgers.Add(customBurgerNumber, newBurger);
		customBurgerNumber++;
    }

	public void removecustomBurger(int itemPosition)
	{
		customBurgers.Remove(itemPosition);
	}
    
    public void setDiningOption(bool _option){
        diningOption = _option;
    }
    
    void checkOut(){
		customBurgers.Clear();
        totalCost = 0;
		customBurgerNumber = 0;
    }

	public void updateTotalCost()
	{
		double cost = 0;

		cost += waters * 1.00;
		cost += cokes * 2.00;
		cost += sprites * 2.00;
		cost += fantas * 2.00;
		cost += rootBeers * 2.00;
		cost += drPeppers * 2.00;
		cost += hamburger * 4.50;
		cost += cheeseburger * 5.00;
		cost += baconBurger * 6.50;
		cost += chickenBurger * 5.00;
		cost += fries * 2.50;
		cost += onionRings * 3.00;
		cost += iceCream * 2.00;

		foreach (KeyValuePair<int, CustomBurger> cb in customBurgers)
		{
			cost += cb.Value.price;
		}
			
		totalCost = cost;
	}
}
