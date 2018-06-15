// Inteface which all cards will implement.

using UnityEngine;

public abstract class Card : MonoBehaviour {
	private bool card_selected = false;

	public abstract string get_class();
	public abstract string get_name();
	public abstract string get_type();
	public abstract int stamina_cost();
	public abstract void card_effect(ref Entity target);

	void Start() {

	}

	void Update() {
		if(Input.GetMouseButtonUp(0)) {
			Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

			RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
			if(!card_selected && hit.collider.gameObject.transform == gameObject.transform) {
				Debug.Log(hit.collider.gameObject.name);
				card_selected = true;
			}
			else if(card_selected && hit.collider.gameObject.tag == "Enemy") {
				Debug.Log(hit.collider.gameObject.name);
				card_selected = false;
			}
		}
	}
}
