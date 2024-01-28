using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss1Movement : MonoBehaviour
{
    private Rigidbody2D body;
    [SerializeField] private Rigidbody2D playerPos;
    [SerializeField] private float startDist;
    [SerializeField] private float acc;

    private bool bossStart;
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(playerPos.position, body.position) < startDist)
        {
            bossStart = true;
        }
        if (bossStart)
        {
            if (body.position.x > playerPos.position.x)
            {
                body.velocity += Vector2.left * new Vector2(acc * Time.deltaTime, body.velocity.y);
            }

            if (body.position.x < playerPos.position.x)
            {
                body.velocity += Vector2.right * new Vector2(acc * Time.deltaTime, body.velocity.y);
            }
        }
    }
}
