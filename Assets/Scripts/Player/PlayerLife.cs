using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    [SerializeField] private const int maxHealth = 10;
    [SerializeField] public int health;
    private SpriteRenderer sprite;
    private Rigidbody2D body;

    // Start is called before the first frame update
    private void Start()
    {
        health = maxHealth;
        sprite = GetComponent<SpriteRenderer>();
        body = GetComponent<Rigidbody2D>();
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
        sprite.enabled = false;
        body.bodyType = RigidbodyType2D.Static;
        Invoke("RestartLevel", 1.0f);
    }
    private void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
