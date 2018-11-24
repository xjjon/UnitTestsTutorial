using UnityEngine;

public class WorldEntityMonoBehaviour : MonoBehaviour
{
    public int StartingHealth = 10;
    private HealthComponent _health;

    void Awake()
    {
        _health = new HealthComponent(StartingHealth);
    }
}