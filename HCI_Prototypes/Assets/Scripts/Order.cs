using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Order {

    // true = dine in. false = take out.
    public bool diningOption = true;
    
    public List<Item> items;
    
    double totalCost = 0;
    
    void addItem(Item item)
    {
        totalCost += item.price;
        items.Add(item);
    }
    
    public void setDiningOption(bool _option){
        diningOption = _option;
    }
    
    void checkOut(){
        items.Clear();
        totalCost = 0;
    }
}
