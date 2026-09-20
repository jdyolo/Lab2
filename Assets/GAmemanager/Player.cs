using UnityEngine;

public class Player : MonoBehaviour
{
    private Health health;
    private Weapon weapon;

    [SerializeField] private Enemy enemy;

    private void Awake()
    {
        health = GetComponent<Health>();
        weapon = GetComponent<Weapon>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            AttackEnemy(enemy);
        }
    }

    public void AttackEnemy(Enemy target)
    {
        if (weapon != null && target != null)
        {
            weapon.Attack(target);
            Debug.Log("Player atacó al enemigo.");
        }
    }
}