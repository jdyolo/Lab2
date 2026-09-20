using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Health health;

    private void Awake()
    {
        health = GetComponent<Health>();
    }

    public void TakeDamage(int damage)
    {
        health.TakeDamage(damage);

        if (IsDead())
        {
            Debug.Log("Enemy está muerto.");
        }
    }

    public bool IsDead()
    {
        return health.GetHealth() <= 0;
    }
}