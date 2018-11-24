using UnityEngine;

public class HealthMonoBehaviour : MonoBehaviour
{
	public int Health { get; private set; }

	public bool IsDead
	{
		get { return Health <= 0; }
	}

	public void Start()
	{
		Health = 10;
	}

	public void RemoveHealth(int amount)
	{
		Health -= amount;
	}
}