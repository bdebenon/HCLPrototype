using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FunctionManager {

    public void dineInTakeOut(string option)
    {
        if (option == "dineIn")
        {
            GameManager.gManager.order.setDiningOption(true);
        }
        else
        {
            GameManager.gManager.order.setDiningOption(false);
        }
        //change menu
    }

    public void addItemToOrder(string item)
    {
        switch (item)
        {
            case "drink_water":
                GameManager.gManager.order.waters++;
                if(GameManager.gManager.currentScene.name == "Instructing")
                    GameManager.gManager.findGameObject("TextWater").GetComponent<Text>().text = GameManager.gManager.order.waters.ToString();
                break;
            case "drink_coke":
                GameManager.gManager.order.cokes++;
                if (GameManager.gManager.currentScene.name == "Instructing")
                    GameManager.gManager.findGameObject("TextCoke").GetComponent<Text>().text = GameManager.gManager.order.cokes.ToString();
                break;
            case "drink_fanta":
                GameManager.gManager.order.fantas++;
                if (GameManager.gManager.currentScene.name == "Instructing")
                    GameManager.gManager.findGameObject("TextFanta").GetComponent<Text>().text = GameManager.gManager.order.fantas.ToString();
                break;
            case "drink_rootBeer":
                GameManager.gManager.order.rootBeers++;
                if (GameManager.gManager.currentScene.name == "Instructing")
                    GameManager.gManager.findGameObject("TextRootbeer").GetComponent<Text>().text = GameManager.gManager.order.rootBeers.ToString();
                break;
            case "drink_sprite":
                GameManager.gManager.order.sprites++;
                if (GameManager.gManager.currentScene.name == "Instructing")
                    GameManager.gManager.findGameObject("TextSprite").GetComponent<Text>().text = GameManager.gManager.order.sprites.ToString();
                break;
            case "drink_drPepper":
                GameManager.gManager.order.drPeppers++;
                if (GameManager.gManager.currentScene.name == "Instructing")
                    GameManager.gManager.findGameObject("TextDrPepper").GetComponent<Text>().text = GameManager.gManager.order.drPeppers.ToString();
                break;
            case "burger_hamburger":
                GameManager.gManager.order.hamburger++;
                if (GameManager.gManager.currentScene.name == "Instructing")
                    GameManager.gManager.findGameObject("TextHamburger").GetComponent<Text>().text = GameManager.gManager.order.hamburger.ToString();
                break;
            case "burger_cheeseburger":
                GameManager.gManager.order.cheeseburger++;
                if (GameManager.gManager.currentScene.name == "Instructing")
                    GameManager.gManager.findGameObject("TextCheeseBurger").GetComponent<Text>().text = GameManager.gManager.order.cheeseburger.ToString();
                break;
            case "burger_baconBurger":
                GameManager.gManager.order.baconBurger++;
                if (GameManager.gManager.currentScene.name == "Instructing")
                    GameManager.gManager.findGameObject("TextBaconBurger").GetComponent<Text>().text = GameManager.gManager.order.baconBurger.ToString();
                break;
            case "burger_chickenBurger":
                GameManager.gManager.order.chickenBurger++;
                if (GameManager.gManager.currentScene.name == "Instructing")
                    GameManager.gManager.findGameObject("TextChickenBurger").GetComponent<Text>().text = GameManager.gManager.order.chickenBurger.ToString();
                break;
            case "burger_customBurger":
                GameManager.gManager.order.addCustomBurger();
                break;
            case "side_fries":
                GameManager.gManager.order.fries++;
                if (GameManager.gManager.currentScene.name == "Instructing")
                    GameManager.gManager.findGameObject("TextFries").GetComponent<Text>().text = GameManager.gManager.order.fries.ToString();
                break;
            case "side_onionRings":
                GameManager.gManager.order.onionRings++;
                if (GameManager.gManager.currentScene.name == "Instructing")
                    GameManager.gManager.findGameObject("TextOnionRings").GetComponent<Text>().text = GameManager.gManager.order.onionRings.ToString();
                break;
            case "side_iceCream":
                GameManager.gManager.order.iceCream++;
                if (GameManager.gManager.currentScene.name == "Instructing")
                    GameManager.gManager.findGameObject("TextIceCream").GetComponent<Text>().text = GameManager.gManager.order.iceCream.ToString();
                break;
        }
    }

    public void removeItemFromOrder(string item)
    {
        switch (item)
        {
            case "drink_water":
                if (GameManager.gManager.order.waters > 0)
                {
                    GameManager.gManager.order.waters--;
                    if (GameManager.gManager.currentScene.name == "Instructing")
                        GameManager.gManager.findGameObject("TextWater").GetComponent<Text>().text = GameManager.gManager.order.waters.ToString();
                }
                break;
            case "drink_coke":
                if (GameManager.gManager.order.cokes > 0)
                {
                    GameManager.gManager.order.cokes--;
                    if (GameManager.gManager.currentScene.name == "Instructing")
                        GameManager.gManager.findGameObject("TextCoke").GetComponent<Text>().text = GameManager.gManager.order.cokes.ToString();
                }
                break;
            case "drink_fanta":
                if (GameManager.gManager.order.fantas > 0)
                {
                    GameManager.gManager.order.fantas--;
                    if (GameManager.gManager.currentScene.name == "Instructing")
                        GameManager.gManager.findGameObject("TextFanta").GetComponent<Text>().text = GameManager.gManager.order.fantas.ToString();
                }
                break;
            case "drink_rootBeer":
                if (GameManager.gManager.order.rootBeers > 0)
                {
                    GameManager.gManager.order.rootBeers--;
                    if (GameManager.gManager.currentScene.name == "Instructing")
                        GameManager.gManager.findGameObject("TextRootbeer").GetComponent<Text>().text = GameManager.gManager.order.rootBeers.ToString();
                }
                break;
            case "drink_sprite":
                if (GameManager.gManager.order.sprites > 0)
                {
                    GameManager.gManager.order.sprites--;
                    if (GameManager.gManager.currentScene.name == "Instructing")
                        GameManager.gManager.findGameObject("TextSprite").GetComponent<Text>().text = GameManager.gManager.order.sprites.ToString();
                }
                break;
            case "drink_drPepper":
                if (GameManager.gManager.order.drPeppers > 0)
                {
                    GameManager.gManager.order.drPeppers--;
                    if (GameManager.gManager.currentScene.name == "Instructing")
                        GameManager.gManager.findGameObject("TextDrPepper").GetComponent<Text>().text = GameManager.gManager.order.drPeppers.ToString();
                }
                break;
            case "burger_hamburger":
                if (GameManager.gManager.order.hamburger > 0)
                {
                    GameManager.gManager.order.hamburger--;
                    if (GameManager.gManager.currentScene.name == "Instructing")
                        GameManager.gManager.findGameObject("TextHamburger").GetComponent<Text>().text = GameManager.gManager.order.hamburger.ToString();
                }
                break;
            case "burger_cheeseburger":
                if (GameManager.gManager.order.cheeseburger > 0)
                {
                    GameManager.gManager.order.cheeseburger--;
                    if (GameManager.gManager.currentScene.name == "Instructing")
                        GameManager.gManager.findGameObject("TextCheeseBurger").GetComponent<Text>().text = GameManager.gManager.order.cheeseburger.ToString();
                }
                break;
            case "burger_baconBurger":
                if (GameManager.gManager.order.baconBurger > 0)
                {
                    GameManager.gManager.order.baconBurger--;
                    if (GameManager.gManager.currentScene.name == "Instructing")
                        GameManager.gManager.findGameObject("TextBaconBurger").GetComponent<Text>().text = GameManager.gManager.order.baconBurger.ToString();
                }
                break;
            case "burger_chickenBurger":
                if (GameManager.gManager.order.chickenBurger > 0)
                {
                    GameManager.gManager.order.chickenBurger--;
                    if (GameManager.gManager.currentScene.name == "Instructing")
                        GameManager.gManager.findGameObject("TextChickenBurger").GetComponent<Text>().text = GameManager.gManager.order.chickenBurger.ToString();
                }
                break;
            case "side_fries":
                if (GameManager.gManager.order.fries > 0)
                {
                    GameManager.gManager.order.fries--;
                    if (GameManager.gManager.currentScene.name == "Instructing")
                        GameManager.gManager.findGameObject("TextFries").GetComponent<Text>().text = GameManager.gManager.order.fries.ToString();
                }
                break;
            case "side_onionRings":
                if (GameManager.gManager.order.onionRings > 0)
                {
                    GameManager.gManager.order.onionRings--;
                    if (GameManager.gManager.currentScene.name == "Instructing")
                        GameManager.gManager.findGameObject("TextOnionRings").GetComponent<Text>().text = GameManager.gManager.order.onionRings.ToString();
                }
                break;
            case "side_iceCream":
                if (GameManager.gManager.order.iceCream > 0)
                {
                    GameManager.gManager.order.iceCream--;
                    if (GameManager.gManager.currentScene.name == "Instructing")
                        GameManager.gManager.findGameObject("TextIceCream").GetComponent<Text>().text = GameManager.gManager.order.iceCream.ToString();
                }
                break;
        }
    }

    public void removeCustomBurger(int number)
    {
        GameManager.gManager.order.removeCustomBurger(number);
    }

    public void checkOut()
    {

    }

    public void switchToScreen(string targetScreen)
    {
        GameManager.gManager.previousMenu.Push(GameManager.gManager.currentMenu);
        GameManager.gManager.mainMenu.SetActive(false);
        GameManager.gManager.burgerMenu.SetActive(false);
        GameManager.gManager.drinksMenu.SetActive(false);
        GameManager.gManager.sidesMenu.SetActive(false);
        GameManager.gManager.viewMenu.SetActive(false);
        GameManager.gManager.checkoutMenu.SetActive(false);
        GameManager.gManager.paymentMenu.SetActive(false);
        GameManager.gManager.currentMenu = targetScreen;
        switch (targetScreen)
        {
            case "Main":
                GameManager.gManager.mainMenu.SetActive(true);
                break;
            case "Burger":
                GameManager.gManager.burgerMenu.SetActive(true);
                break;
            case "Drinks":
                GameManager.gManager.drinksMenu.SetActive(true);
                break;
            case "Sides":
                GameManager.gManager.sidesMenu.SetActive(true);
                break;
            case "Checkout":
                GameManager.gManager.order.updateOrder();
                GameManager.gManager.checkoutMenu.SetActive(true);
                closeCancelScreen();
                closeConfirmationScreen();
                break;
            case "Payment":
                GameManager.gManager.paymentMenu.SetActive(true);
                break;
        }
    }

    public void returnToPreviousScreen()
    {
        string previous;
        if (GameManager.gManager.previousMenu.Count > 0)
            previous = GameManager.gManager.previousMenu.Pop();
        else
            previous = "Main";
        GameManager.gManager.mainMenu.SetActive(false);
        GameManager.gManager.burgerMenu.SetActive(false);
        GameManager.gManager.drinksMenu.SetActive(false);
        GameManager.gManager.sidesMenu.SetActive(false);
        GameManager.gManager.viewMenu.SetActive(false);
        GameManager.gManager.checkoutMenu.SetActive(false);
        GameManager.gManager.currentMenu = previous;
        switch (previous)
        {
            case "Main":
                GameManager.gManager.mainMenu.SetActive(true);
                break;
            case "Burger":
                GameManager.gManager.burgerMenu.SetActive(true);
                break;
            case "Drinks":
                GameManager.gManager.drinksMenu.SetActive(true);
                break;
            case "Sides":
                GameManager.gManager.sidesMenu.SetActive(true);
                break;
            case "Checkout":
                GameManager.gManager.order.updateOrder();
                GameManager.gManager.checkoutMenu.SetActive(true);
                closeCancelScreen();
                closeConfirmationScreen();
                break;
        }
    }
    public void resetTextFields()
    {
        GameManager.gManager.findGameObject("TextWater").GetComponent<Text>().text = GameManager.gManager.order.waters.ToString();
        GameManager.gManager.findGameObject("TextCoke").GetComponent<Text>().text = GameManager.gManager.order.cokes.ToString();
        GameManager.gManager.findGameObject("TextFanta").GetComponent<Text>().text = GameManager.gManager.order.fantas.ToString();
        GameManager.gManager.findGameObject("TextRootbeer").GetComponent<Text>().text = GameManager.gManager.order.rootBeers.ToString();
        GameManager.gManager.findGameObject("TextSprite").GetComponent<Text>().text = GameManager.gManager.order.sprites.ToString();
        GameManager.gManager.findGameObject("TextDrPepper").GetComponent<Text>().text = GameManager.gManager.order.drPeppers.ToString();
        GameManager.gManager.findGameObject("TextHamburger").GetComponent<Text>().text = GameManager.gManager.order.hamburger.ToString();
        GameManager.gManager.findGameObject("TextCheeseBurger").GetComponent<Text>().text = GameManager.gManager.order.cheeseburger.ToString();
        GameManager.gManager.findGameObject("TextBaconBurger").GetComponent<Text>().text = GameManager.gManager.order.baconBurger.ToString();
        GameManager.gManager.findGameObject("TextChickenBurger").GetComponent<Text>().text = GameManager.gManager.order.chickenBurger.ToString();
        GameManager.gManager.findGameObject("TextFries").GetComponent<Text>().text = GameManager.gManager.order.fries.ToString();
        GameManager.gManager.findGameObject("TextOnionRings").GetComponent<Text>().text = GameManager.gManager.order.onionRings.ToString();
        GameManager.gManager.findGameObject("TextIceCream").GetComponent<Text>().text = GameManager.gManager.order.iceCream.ToString();
    }
    public void cancelOrder()
    {
        GameManager.gManager.initializeScene();
        GameManager.gManager.LoadMainMenu();
        if(GameManager.gManager.currentScene.name == "Instructing")
            resetTextFields();
    }
    public void openViewOrder()
    {
        GameManager.gManager.order.updateOrder();
        GameManager.gManager.viewMenu.SetActive(true);
    }
    public void closeViewOrder()
    {
        GameManager.gManager.viewMenu.SetActive(false);
    }
    public void showConfirmationScreen()
    {
        GameManager.gManager.findGameObject("ConfirmationScreen").SetActive(true);
    }
    public void closeConfirmationScreen()
    {
        GameManager.gManager.findGameObject("ConfirmationScreen").SetActive(false);
    }
    public void showCancelScreen()
    {
        GameManager.gManager.findGameObject("CancelScreen").SetActive(true);
    }
    public void closeCancelScreen()
    {
        GameManager.gManager.findGameObject("CancelScreen").SetActive(false);
    }

}
