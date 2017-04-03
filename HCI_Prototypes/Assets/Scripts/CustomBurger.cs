using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomBurger {

    public string name;
    public enum Options { beef, chicken, bacon, cheese, lettuce, tomato, pickle, onion, ketchup, mustard, mayo };
	public Dictionary<Options, bool> options;
	public Dictionary<Options, double> optionPrices;
	public double price = 0;
    
	public CustomBurger()
	{
		price = 2.50;

        options.Add (Options.beef, false);
		options.Add (Options.chicken, false);
		options.Add (Options.bacon, false);
		options.Add (Options.cheese, false);
		options.Add (Options.lettuce, false);
		options.Add (Options.tomato, false);
		options.Add (Options.pickle, false);
		options.Add (Options.onion, false);
		options.Add (Options.ketchup, false);
		options.Add (Options.mustard, false);
		options.Add (Options.mayo, false);
        
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

    void addOption(Options option)
    {
		options [option] = true;
        updatePrice();
    }

	void removeOption(Options option)
	{
		options[option] = false;
		updatePrice();
	}
    
    void updatePrice()
    {
		double tempPrice = 0;
		foreach (KeyValuePair<Options, bool> o in options) {
			if (o.Value == true) {
				tempPrice += optionPrices [o.Key];
			}
		}
		tempPrice += 2.5;

		price = tempPrice;
    }

}
