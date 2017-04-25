using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drink : MonoBehaviour {

    public string type = "";
	public bool onTray = false;

    public void SetType(string _type)
    {
        type = _type;        
    }

}
