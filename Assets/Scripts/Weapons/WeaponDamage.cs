using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponDamage : MonoBehaviour
{
    [SerializeField] private int damage;
    [SerializeField] public EnemyLife enemyLife;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            enemyLife.TakeDamage(damage);
        }
    }
}
