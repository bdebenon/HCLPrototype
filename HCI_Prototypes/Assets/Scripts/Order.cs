using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Order {

    // If dineIn is false then the order is take out
    public bool dineIn = true;
    
    public List<Item> items;
    
    double totalCost = 0;
    
    void addItem(Item item)
    {
        totalCost += item.price;
        items.Add(item);
    }
    
    void takeOut(){
        dineIn = false;
    }
    
    void checkOut(){
        items.Clear();
        totalCost = 0;
    }
}
