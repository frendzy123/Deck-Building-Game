// Abstract class from which all game entities will inherit from

public abstract class Entity {
	private int health;
	private int stamina;

	public Entity() {
		health = 100;
		stamina = 100;
	}

	public Entity(int h, int s) {
		health = h;
		stamina = s;
	}

	public int get_health() {
		return health;
	}

	public int get_stamina() {
		return stamina;
	}

	public int add_health(int change) {
		health += change;
		return health;
	}

	public int add_stamina(int change) {
		stamina += change;
		return stamina;
	}

	// Function that specifies the behaviour an Entity's unique ability
	public abstract void hero_power();

	// Function that returns the class of the Entity.
	public abstract string get_class();
}