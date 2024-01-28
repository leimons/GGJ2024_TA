using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponsScriptForBoss : MonoBehaviour
{
    [SerializeField] private int damage;
    [SerializeField] public BossHealth bossHealth;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Boss")
        {
            bossHealth.TakeDamage(damage);
            Destroy(gameObject);
        }
    }
}
