// Inteface which all cards will implement.

using UnityEngine;

public abstract class Card : MonoBehaviour {
	public abstract string get_class();
	public abstract string get_name();
	public abstract string get_type();
	public abstract int stamina_cost();
	public abstract void card_effect(ref Entity target);

	void Start() {

	}

	void Update() {

	}
}
