// Class that handles the player's hand, deck and overall deck_list

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour {
	private List<GameObject> deck_list;
	private List<GameObject> current_deck;
	private List<GameObject> current_hand;

	void Start() {
		deck_list = new List<GameObject>();
		current_deck = new List<GameObject>(deck_list);

		for(int i = 0; i < 10; i++) {
			current_deck.Add(Instantiate(Resources.Load("Prefabs/Strike")) as GameObject);
			current_deck[i].SetActive(false);
		}

		current_hand = new List<GameObject>(deck_list);
		shuffle();
		draw(5);
	}

	void Update() {
		for(int i = 0; i < current_hand.Count; i++) {
			if(current_hand[i] == null) {
				current_hand.RemoveAt(i);
				for(int k = i; k < current_hand.Count; k++) {
					int position_x = -5 + k * 2;
					current_hand[k].transform.position = new Vector3(position_x, -3, 0);
				}
			}
		}
	}

	public void draw(int card_draw) {
		for(int i = 0; i < card_draw; i++) {
			if(current_deck.Count != 0) {
				current_hand.Add(current_deck[0]);
				current_hand[current_hand.Count - 1].SetActive(true);
				int position_x = -5 + i * 2;
				current_hand[current_hand.Count - 1].transform.position = new Vector3(position_x, -3, 0);
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

	public List<GameObject> get_hand() {
		return current_hand;
	}
}
