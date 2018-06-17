using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Draggable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler {

	Transform returnTo = null;

	public void OnBeginDrag(PointerEventData eventData) 
	{

		returnTo = this.transform.parent;
		this.transform.SetParent(this.transform.parent.parent); //Takes it outside of hand
		Debug.Log ("OnBeginDrag");

		GetComponent<CanvasGroup>().blocksRaycasts = false;
	}

	public void OnDrag(PointerEventData eventData)
	{
		Debug.Log ("Drag");

		this.transform.position = eventData.position; 
	}

	public void OnEndDrag(PointerEventData eventData)
	{
		Debug.Log ("End drag");
		this.transform.SetParent(returnTo);

		List<RaycastResult> hits = new List<RaycastResult>();

		EventSystem.current.RaycastAll(eventData, hits);

		for (int i = 0; i < hits.Count; i++) {
			if (hits [i].gameObject.tag == "Enemy") {
				Destroy (this.gameObject);
			}
		}

		GetComponent<CanvasGroup>().blocksRaycasts = true;
	}

}
