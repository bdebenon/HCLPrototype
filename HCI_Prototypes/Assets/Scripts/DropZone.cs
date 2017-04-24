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
				//GameManager.gManager.functionManager.addItemToOrder("drink_coke");
				//Object newCup = Instantiate(eventData.pointerDrag, new Vector3(300, -200, 0), Quaternion.identity);
				eventData.pointerDrag.GetComponent<Image> ().sprite = otherSprite;
				d.parentToReturnTo = GameManager.gManager.drinksTray.transform;
			} else if (gameObject.name == "DrPepperDispenser") {
				//GameManager.gManager.functionManager.addItemToOrderButton("drink_coke");
				eventData.pointerDrag.GetComponent<Image> ().sprite = otherSprite;
				d.parentToReturnTo = GameManager.gManager.drinksTray.transform;
			} else if (gameObject.name == "FantaDispenser") {
				//GameManager.gManager.functionManager.addItemToOrderButton("drink_coke");
				eventData.pointerDrag.GetComponent<Image> ().sprite = otherSprite;
				d.parentToReturnTo = GameManager.gManager.drinksTray.transform;
			} else if (gameObject.name == "RootbeerDispenser") {
				//GameManager.gManager.functionManager.addItemToOrderButton("drink_coke");
				eventData.pointerDrag.GetComponent<Image> ().sprite = otherSprite;
				d.parentToReturnTo = GameManager.gManager.drinksTray.transform;
			} else if (gameObject.name == "SpriteDispenser") {
				//GameManager.gManager.functionManager.addItemToOrderButton("drink_coke");
				eventData.pointerDrag.GetComponent<Image> ().sprite = otherSprite;
				d.parentToReturnTo = GameManager.gManager.drinksTray.transform;
			} else if (gameObject.name == "WaterDispenser") {
				//GameManager.gManager.functionManager.addItemToOrderButton("drink_coke");
				eventData.pointerDrag.GetComponent<Image> ().sprite = otherSprite;
				d.parentToReturnTo = GameManager.gManager.drinksTray.transform;
			} else {
				d.parentToReturnTo = this.transform;
			}
        }
        
        
        
        
    }
    
}
