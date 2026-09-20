using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private int health = 100;
    [SerializeField] private int maxHealth = 100;

    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health < 0)
            health = 0;

        Debug.Log("Daño recibido: " + damage);
        Debug.Log("Vida actual: " + health);
    }

    public void Heal(int amount)
    {
        health += amount;

        if (health > maxHealth)
            health = maxHealth;

        Debug.Log("Curación recibida: " + amount);
        Debug.Log("Vida actual: " + health);
    }

    public int GetHealth()
    {
        return health;
    }
}
