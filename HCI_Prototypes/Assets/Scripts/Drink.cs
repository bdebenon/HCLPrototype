using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drink : Item {

    string type = "";

    public void SetType(string _type)
    {
        type = _type;
        setPrice(type);
        
    }
    
    public void setPrice(string type){
        
        if(type.Equals("water"))
        {
            price = 0;
        }
        else    // drink is a soda
        {
            price = 2;
        }
    }

}
