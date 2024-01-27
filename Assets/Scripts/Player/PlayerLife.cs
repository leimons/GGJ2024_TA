using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLife : MonoBehaviour
{
    [SerializeField] private const int maxHealth = 10;
    [SerializeField] private int health;

    // Start is called before the first frame update
    private void Start()
    {
        health = maxHealth;
    }
    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }

    private void Die() 
    {
        Destroy(gameObject);
    }
}
