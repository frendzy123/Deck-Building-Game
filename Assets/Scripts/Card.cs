// Abstract class from which all cards will inherit from.

using UnityEngine;

public abstract class Card {
	public abstract string get_class();
	public abstract string get_name();
	public abstract string get_type();
	public abstract int stamina_cost();
	public abstract void card_effect();
}
