using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlightBase : MonoBehaviour
{
    private Rigidbody2D body;
    private float initPos;
    [SerializeField] private float flap = 5.0f;

    private void Start()
    {
        body = GetComponent<Rigidbody2D>();
        initPos = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < initPos - 5.0f)
        {
            body.velocity = new Vector2(body.velocity.x, flap);
        }
    }
}
