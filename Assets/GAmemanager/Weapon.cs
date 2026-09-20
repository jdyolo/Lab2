using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] private int damage = 25;

    public void Attack(Enemy target)
    {
        if (target != null)
        {
            target.TakeDamage(damage);
            Debug.Log("Ataque realizado. Daño: " + damage);
        }
    }
}