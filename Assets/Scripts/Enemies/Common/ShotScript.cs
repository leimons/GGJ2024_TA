using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class ShotScript : MonoBehaviour
{
    private GameObject player;
    private Rigidbody2D body;
    [SerializeField] private float force;

    [SerializeField] private PlayerLife playerLife;
    [SerializeField] private int damage = 5;

    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player");

        Vector2 direction = player.transform.position - transform.position;
        body.velocity = new Vector2(direction.x, direction.y).normalized * force;

        float rot = Mathf.Atan2(-direction.x, -direction.y) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, rot + 90);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > 2)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.CompareTag("Player"))
        {
            playerLife = collision.gameObject.GetComponent<PlayerLife>();
            playerLife.TakeDamage(damage);
            Destroy(gameObject);
        }
    }
}
