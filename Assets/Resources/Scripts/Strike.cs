using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Strike : Card {

	public override string get_class() {
		return "Berserker";
	}

	public override string get_name() {
		return "Strike";
	}

	public override string get_type() {
		return "Offensive";
	}

	public override int stamina_cost() {
		return 1;
	}

	public override void card_effect(GameObject target) {
		Player player = target.GetComponent(typeof(Player)) as Player;
		player.entity_class.add_health(-5);
	}
}
