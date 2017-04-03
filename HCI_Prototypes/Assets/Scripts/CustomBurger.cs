using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomBurger {

    public string name;
    public enum Options { beef, chicken, bacon, cheese, lettuce, tomato, pickle, onion, ketchup, mustard, mayo };
	public Dictionary<Options, bool> options;
	public Dictionary<Options, int> optionPrices;
	public double price = 0;
    
	public CustomBurger()
	{
		price = 2.50;
		for (int i = 0; i < 11; i++) {
			options.Add (Options[i], false);
		}

		optionPrices.Add (Options.beef, 2.0);
		optionPrices.Add (Options.chicken, 2.5);
		optionPrices.Add (Options.bacon, 1.5);
		optionPrices.Add (Options.cheese, 0.5);
		optionPrices.Add (Options.lettuce, 0);
		optionPrices.Add (Options.tomato, 0);
		optionPrices.Add (Options.pickle, 0);
		optionPrices.Add (Options.onion, 0);
		optionPrices.Add (Options.ketchup, 0);
		optionPrices.Add (Options.mustard, 0);
		optionPrices.Add (Options.mayo, 0);

		updatePrice ();
	}

    void addOption(int _option)
    {
        options[_option] = true;
        updatePrice();
    }

	void removeOption(int _option)
	{
		options[_option] = false;
		updatePrice();
	}
    
    void updatePrice()
    {
		double tempPrice = 0;
		foreach (Options o in options) {
			if (o == true) {
				tempPrice += optionPrices [o];
			}
		}
		tempPrice += 2.5;

		price = tempPrice;
    }

}
