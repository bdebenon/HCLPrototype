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
        if(d != null){
            
			if (gameObject.name == "CokeDispenser") {
				
				GameManager.gManager.functionManager.addItemToOrder ("drink_coke");

				GameObject newCup = Instantiate(GameManager.gManager.cup, Vector3.zero, Quaternion.identity, GameManager.gManager.drinksMenu.transform);
				newCup.transform.localPosition = new Vector3 (300, -200, 0);

				eventData.pointerDrag.GetComponent<Image> ().sprite = otherSprite;
				d.parentToReturnTo = GameManager.gManager.drinksTray.transform;

			} else if (gameObject.name == "DrPepperDispenser") {
				GameManager.gManager.functionManager.addItemToOrder ("drink_coke");

				GameObject newCup = Instantiate(GameManager.gManager.cup, Vector3.zero, Quaternion.identity, GameManager.gManager.drinksMenu.transform);
				newCup.transform.localPosition = new Vector3 (300, -200, 0);

				eventData.pointerDrag.GetComponent<Image> ().sprite = otherSprite;
				d.parentToReturnTo = GameManager.gManager.drinksTray.transform;
			} else if (gameObject.name == "FantaDispenser") {
				GameManager.gManager.functionManager.addItemToOrder ("drink_coke");

				GameObject newCup = Instantiate(GameManager.gManager.cup, Vector3.zero, Quaternion.identity, GameManager.gManager.drinksMenu.transform);
				newCup.transform.localPosition = new Vector3 (300, -200, 0);

				eventData.pointerDrag.GetComponent<Image> ().sprite = otherSprite;
				d.parentToReturnTo = GameManager.gManager.drinksTray.transform;
			} else if (gameObject.name == "RootbeerDispenser") {
				GameManager.gManager.functionManager.addItemToOrder ("drink_coke");

				GameObject newCup = Instantiate(GameManager.gManager.cup, Vector3.zero, Quaternion.identity, GameManager.gManager.drinksMenu.transform);
				newCup.transform.localPosition = new Vector3 (300, -200, 0);

				eventData.pointerDrag.GetComponent<Image> ().sprite = otherSprite;
				d.parentToReturnTo = GameManager.gManager.drinksTray.transform;
			} else if (gameObject.name == "SpriteDispenser") {
				GameManager.gManager.functionManager.addItemToOrder ("drink_coke");

				GameObject newCup = Instantiate(GameManager.gManager.cup, Vector3.zero, Quaternion.identity, GameManager.gManager.drinksMenu.transform);
				newCup.transform.localPosition = new Vector3 (300, -200, 0);

				eventData.pointerDrag.GetComponent<Image> ().sprite = otherSprite;
				d.parentToReturnTo = GameManager.gManager.drinksTray.transform;
			} else if (gameObject.name == "WaterDispenser") {
				GameManager.gManager.functionManager.addItemToOrder ("drink_coke");

				GameObject newCup = Instantiate(GameManager.gManager.cup, Vector3.zero, Quaternion.identity, GameManager.gManager.drinksMenu.transform);
				newCup.transform.localPosition = new Vector3 (300, -200, 0);

				eventData.pointerDrag.GetComponent<Image> ().sprite = otherSprite;
				d.parentToReturnTo = GameManager.gManager.drinksTray.transform;
			} else {
				d.parentToReturnTo = this.transform;
			}
        }
        
        
        
        
    }
    
}
