using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void dineInTakeOutButton(string option){
        GameManager.gManager.functionManager.dineInTakeOut(option);
    }

	public void addItemToOrderButton(string item){
        GameManager.gManager.functionManager.addItemToOrder(item);

    }
    public void removeItemFromOrderButton(string item)
    {
        GameManager.gManager.functionManager.removeItemFromOrder(item);
    }
	public void removeCustomBurgerButton(int number)
	{
        GameManager.gManager.functionManager.removeCustomBurger(number);

    }
	public void checkOutButton(){
        GameManager.gManager.functionManager.checkOut();

    }
    public void switchToScreenButton(string targetScreen)
    {
        GameManager.gManager.functionManager.switchToScreen(targetScreen);
    }

    public void returnToPreviousScreenButton() 
    {
        GameManager.gManager.functionManager.returnToPreviousScreen();
    }
    void resetTextFieldsButton()
    {
        GameManager.gManager.functionManager.resetTextFields();
    }
    public void cancelOrderbutton()
    {
        GameManager.gManager.functionManager.cancelOrder();
    }
    public void openViewOrderButton()
    {
        GameManager.gManager.functionManager.openViewOrder();
    }
    public void closeViewOrderButton()
    {
        GameManager.gManager.functionManager.closeViewOrder();
    }
    public void showConfirmationScreenButton()
    {
        GameManager.gManager.functionManager.showConfirmationScreen();
    }
    public void closeConfirmationScreenButton()
    {
        GameManager.gManager.functionManager.closeConfirmationScreen();
    }
    public void showCancelScreenButton()
    {
        GameManager.gManager.functionManager.showCancelScreen();
    }
    public void closeCancelScreenButton()
    {
        GameManager.gManager.functionManager.closeCancelScreen();
    }

}
