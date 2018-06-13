// Berserker class inheriting from Entity class.

public class Berserker : Entity {
	private int rage = 0;

	public int get_rage() {
		return rage;
	}

	public int add_rage(int change) {
		rage += change;
		return rage;
	}

	public override void hero_power() {
		rage += 1;
	}

	public override string get_class() {
		return "Berserker";
	}
}