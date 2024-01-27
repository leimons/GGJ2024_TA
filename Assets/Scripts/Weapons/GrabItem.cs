using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabItem : MonoBehaviour
{
    [SerializeField] private Transform arm;
    [SerializeField] private float throwForce = 0.0f;
    private bool collisionBool;
    private Rigidbody2D body;

    private void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (collisionBool == true)
        {
            transform.position = new Vector2(arm.position.x + 1.0f, arm.position.y);
            if (Input.GetKeyDown("e") == true) 
            {
                body.velocity = new Vector2(throwForce, body.velocity.y);
                collisionBool = false;
            }        
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collisionBool = true;
        }
    }
}