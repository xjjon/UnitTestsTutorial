public class HealthComponent
{
    public int Health { get; private set; }

    public bool IsDead
    {
        get { return Health <= 0; }
    }

    public HealthComponent(int health)
    {
        Health = health;
    }

    public void RemoveHealth(int amount)
    {
        Health -= amount;
    }
}
