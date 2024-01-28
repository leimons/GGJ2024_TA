using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinionScript : MonoBehaviour
{
    private GameObject player;
    private Rigidbody2D body;
    [SerializeField]private float moveSpeed = 3f;
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        body.position = new Vector2(body.position.x - 2, body.position.y);
        player = GameObject.FindGameObjectWithTag("Player");

        body.velocity = new Vector2(0f, 7f);
    }

    // Update is called once per frame
    void Update()
    {
        if (body.position.x > player.GetComponent<Rigidbody2D>().position.x)
        {
            body.velocity = Vector2.left * new Vector2(moveSpeed, 0);
        }

        if (body.position.x < player.GetComponent<Rigidbody2D>().position.x)
        {
            body.velocity = Vector2.right * new Vector2(moveSpeed, 0);
        }
    }
}
