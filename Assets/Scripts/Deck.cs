// Class that handles the player's hand, deck and overall deck_list

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck {
	private List<GameObject> deck_list;
	private List<GameObject> current_deck;
	private List<GameObject> current_hand;

	public Deck() {
		deck_list = new List<GameObject>();
		current_deck = new List<GameObject>(deck_list);
		current_hand = new List<GameObject>(deck_list);
		shuffle();
		draw(5);
	}

	public void draw(int card_draw) {
		for(int i = 0; i < card_draw; i++) {
			if(current_deck.Count != 0) {
				current_hand.Add(current_deck[0]);
				current_deck.RemoveAt(0);
			}	
		}
	}

	public void shuffle() {
		for(int i = 0; i < current_deck.Count; i++) {
			int rand = (int) (Random.value * current_deck.Count);
			var temp = current_deck[rand];
			current_deck[rand] = current_deck[i];
			current_deck[i] = temp;
		}
	}

	public void add(GameObject card) {
		current_deck.Add(card);
	}

	public void remove(int index) {
		current_deck.RemoveAt(index);
	}
}
