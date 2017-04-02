using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    
    public void dineInTakeOutButton(string option){
        if(option == "dineIn"){
            GameManager.gManager.order.setDiningOption(true);
        }
        else{
            GameManager.gManager.order.setDiningOption(false);
        }
        //change menu
    }
}
