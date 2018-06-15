using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler {

	public void OnPointerEnter(PointerEventData eventData)
	{
		//Debug.Log ("pointer enter");
	}

	public void OnPointerExit(PointerEventData eventData)
	{
		//Debug.Log ("pointer exit");
	}

	public void OnDrop(PointerEventData eventData) {
		Debug.Log ("dropped to " + gameObject.name);
	}
}
