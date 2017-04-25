using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DropZone : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler {

    public void OnPointerEnter(PointerEventData eventData) {
        Debug.Log("OnPointerEnter");
    }
    
    public void OnPointerExit(PointerEventData eventData) {
        Debug.Log("OnPointerExit");
    }
    
	public Sprite otherSprite;

    public void OnDrop(PointerEventData eventData) {
        Debug.Log(eventData.pointerDrag.name + " was dropped on " + gameObject.name);
        
        Draggable d = eventData.pointerDrag.GetComponent<Draggable>();
		if (d != null) {
            
			if (gameObject.name == "CokeDispenser") {

				if (eventData.pointerDrag.GetComponent<Drink> ().type != "") {
					GameManager.gManager.functionManager.removeItemFromOrder ("drink_" + eventData.pointerDrag.GetComponent<Drink> ().type);
				}
				eventData.pointerDrag.GetComponent<Drink> ().SetType ("coke");
				GameManager.gManager.functionManager.addItemToOrder ("drink_coke");

				GameObject newCup = Instantiate (GameManager.gManager.cup, Vector3.zero, Quaternion.identity, GameManager.gManager.drinksMenu.transform);
				newCup.transform.localPosition = new Vector3 (300, -200, 0);

				eventData.pointerDrag.GetComponent<Image> ().sprite = otherSprite;
				d.parentToReturnTo = GameManager.gManager.drinksTray.transform;

			} else if (gameObject.name == "DrPepperDispenser") {
				if (eventData.pointerDrag.GetComponent<Drink> ().type != "") {
					GameManager.gManager.functionManager.removeItemFromOrder ("drink_" + eventData.pointerDrag.GetComponent<Drink> ().type);
				}
				eventData.pointerDrag.GetComponent<Drink> ().SetType ("drPepper");
				GameManager.gManager.functionManager.addItemToOrder ("drink_drPepper");

				GameObject newCup = Instantiate (GameManager.gManager.cup, Vector3.zero, Quaternion.identity, GameManager.gManager.drinksMenu.transform);
				newCup.transform.localPosition = new Vector3 (300, -200, 0);

				eventData.pointerDrag.GetComponent<Image> ().sprite = otherSprite;
				d.parentToReturnTo = GameManager.gManager.drinksTray.transform;
			} else if (gameObject.name == "FantaDispenser") {
				if (eventData.pointerDrag.GetComponent<Drink> ().type != "") {
					GameManager.gManager.functionManager.removeItemFromOrder ("drink_" + eventData.pointerDrag.GetComponent<Drink> ().type);
				}
				eventData.pointerDrag.GetComponent<Drink> ().SetType ("fanta");
				GameManager.gManager.functionManager.addItemToOrder ("drink_fanta");

				GameObject newCup = Instantiate (GameManager.gManager.cup, Vector3.zero, Quaternion.identity, GameManager.gManager.drinksMenu.transform);
				newCup.transform.localPosition = new Vector3 (300, -200, 0);

				eventData.pointerDrag.GetComponent<Image> ().sprite = otherSprite;
				d.parentToReturnTo = GameManager.gManager.drinksTray.transform;
			} else if (gameObject.name == "RootbeerDispenser") {
				if (eventData.pointerDrag.GetComponent<Drink> ().type != "") {
					GameManager.gManager.functionManager.removeItemFromOrder ("drink_" + eventData.pointerDrag.GetComponent<Drink> ().type);
				}
				eventData.pointerDrag.GetComponent<Drink> ().SetType ("rootBeer");
				GameManager.gManager.functionManager.addItemToOrder ("drink_rootBeer");

				GameObject newCup = Instantiate (GameManager.gManager.cup, Vector3.zero, Quaternion.identity, GameManager.gManager.drinksMenu.transform);
				newCup.transform.localPosition = new Vector3 (300, -200, 0);

				eventData.pointerDrag.GetComponent<Image> ().sprite = otherSprite;
				d.parentToReturnTo = GameManager.gManager.drinksTray.transform;
			} else if (gameObject.name == "SpriteDispenser") {
				if (eventData.pointerDrag.GetComponent<Drink> ().type != "") {
					GameManager.gManager.functionManager.removeItemFromOrder ("drink_" + eventData.pointerDrag.GetComponent<Drink> ().type);
				}
				eventData.pointerDrag.GetComponent<Drink> ().SetType ("sprite");
				GameManager.gManager.functionManager.addItemToOrder ("drink_sprite");

				GameObject newCup = Instantiate (GameManager.gManager.cup, Vector3.zero, Quaternion.identity, GameManager.gManager.drinksMenu.transform);
				newCup.transform.localPosition = new Vector3 (300, -200, 0);

				eventData.pointerDrag.GetComponent<Image> ().sprite = otherSprite;
				d.parentToReturnTo = GameManager.gManager.drinksTray.transform;
			} else if (gameObject.name == "WaterDispenser") {
				if (eventData.pointerDrag.GetComponent<Drink> ().type != "") {
					GameManager.gManager.functionManager.removeItemFromOrder ("drink_" + eventData.pointerDrag.GetComponent<Drink> ().type);
				}
				eventData.pointerDrag.GetComponent<Drink> ().SetType ("water");
				GameManager.gManager.functionManager.addItemToOrder ("drink_water");

				GameObject newCup = Instantiate (GameManager.gManager.cup, Vector3.zero, Quaternion.identity, GameManager.gManager.drinksMenu.transform);
				newCup.transform.localPosition = new Vector3 (300, -200, 0);

				eventData.pointerDrag.GetComponent<Image> ().sprite = otherSprite;
				d.parentToReturnTo = GameManager.gManager.drinksTray.transform;
			} else if (gameObject.name == "DrinksTray") {
				d.parentToReturnTo = this.transform;
			}
			else if (gameObject.name == "SidesTray") {

				string side_type = eventData.pointerDrag.GetComponent<Side> ().type;
				GameManager.gManager.functionManager.addItemToOrder ("side_" + side_type);

				if (side_type == "fries") {
					GameObject newFries = Instantiate (GameManager.gManager.fries, Vector3.zero, Quaternion.identity, GameManager.gManager.sidesMenu.transform);
					newFries.transform.localPosition = new Vector3 (-300, 100, 0);
				} else if (side_type == "onionRings") {
					GameObject newOnionRings = Instantiate (GameManager.gManager.onionRings, Vector3.zero, Quaternion.identity, GameManager.gManager.sidesMenu.transform);
					newOnionRings.transform.localPosition = new Vector3 (0, 100, 0);
				} else if (side_type == "iceCream") {
					GameObject newIceCream = Instantiate (GameManager.gManager.iceCream, Vector3.zero, Quaternion.identity, GameManager.gManager.sidesMenu.transform);
					newIceCream.transform.localPosition = new Vector3 (300, 100, 0);
				}
					
				d.parentToReturnTo = GameManager.gManager.sidesTray.transform;
			}

			else {
				d.parentToReturnTo = this.transform;
			}
		}    
        
        
        
    }
    
}
