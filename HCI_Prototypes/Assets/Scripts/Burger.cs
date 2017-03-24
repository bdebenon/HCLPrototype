using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Burger : Item {

    public string name;
    public enum Options { beef, chicken, bacon, cheese, lettuce, tomato, pickle, onion, ketchup, mustard, mayo };
    public bool[] hasOptions = new bool[10]; // initialized to false
    
    // the prices in this array correspond to the option in the Options enum with the same index
    double[] optionPrices = { 2, 2.5, 1.5, 0.5, 0, 0, 0, 0, 0, 0, 0 };
    
    
    void addOption(int _option)
    {
        hasOptions[_option] = true;
        updatePrice(_option);
    }
    
    void updatePrice(int _option)
    {
        price += optionPrices[_option];
    }

}
