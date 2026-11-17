public class Hero {
    public string Name { get; private set; }
    public int Health { get; private set; }
    public int Level { get; private set; }
    public int Experience { get; private set; }

    public Hero(string name, int health) {
        Name = name.Trim();
        Health = health;
        Level = 1;
        Experience = 0;
    }

    public void TakeDamage(int damage) {
        Health -= damage;
        if (Health < 0) Health = 0;
    }

    public void Heal(int amount) {
        Health += amount;
        if (Health > 150) Health = 150;
    }

    public void GainExperience(int amount) {
        Experience += amount;
    }

    public bool IsAlive() => Health > 0;

    public string GetInfo() {
        return $">>> {Name} <<<\nЗдоровье: {Health}\nУровень: {Level}\nОпыт: {Experience}";
    }
}