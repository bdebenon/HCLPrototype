using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Side : Item {

    string type = "";

    public void SetType(string _type)
    {
        type = _type;
        setPrice(type);
        
    }
    
    public void setPrice(string type){
        
        if(type.Equals("fries"))
        {
            price = 2.5;
        }
        else if(type.Equals("onion rings"))    // drink is a soda
        {
            price = 3;
        }
        else if(type.Equals("ice cream"))
        {
            price = 2;
        }
        else
        {
            price = 0;
        }
        
    }

}