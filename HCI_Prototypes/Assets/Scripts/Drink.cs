using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

[Serializable]
public class Drink : MonoBehaviour {

    public string type = "";
	public bool onTray = false;
    public bool initialized = false;

    public void SetType(string _type)
    {
        type = _type;        
    }

}
