// Inteface which all cards will implement.

using UnityEngine;
using System;

public abstract class Card : MonoBehaviour {

	private bool card_selected = false;
	private Vector2 original_position = Vector2.zero;

	public abstract string get_class();
	public abstract string get_name();
	public abstract string get_type();
	public abstract int stamina_cost();
	public abstract void card_effect(GameObject target);

	void Start() {

	}

	void Update() {
		try {	
			if(Input.GetMouseButton(0)) {
				Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
				Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

				RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
				if(!card_selected && hit.collider.gameObject.transform == gameObject.transform) {
					card_selected = true;
					original_position = gameObject.transform.position;
				}
				else if (card_selected) {
					gameObject.transform.position = mousePos2D;
				}
			}
			else if(Input.GetMouseButtonUp(0)) {
				if(card_selected) {
					RaycastHit2D hit = Physics2D.Raycast(gameObject.transform.position, Vector2.zero);
					if(hit.collider.gameObject.tag == "Enemy") {
						card_effect(hit.collider.gameObject);
						Destroy(gameObject);
					}
					else {
						gameObject.transform.position = original_position;
					}
					card_selected = false;
				}
			}
		}
		catch (NullReferenceException e) {}
	}
}
