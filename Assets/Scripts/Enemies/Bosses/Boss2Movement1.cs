using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Boss2Movement : MonoBehaviour
{
    private Rigidbody2D body;
    [SerializeField] private Rigidbody2D playerPos;
    [SerializeField] private float startDist;
    [SerializeField] private float acc;

    private float timer;
    private bool bossStart;

    [SerializeField] private GameObject minion;
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
            timer += Time.deltaTime;

            print(timer);

            if (timer > 3)
            {
                Instantiate(minion, this.transform);
                timer = 0;
            }
            else
            {
                if (body.position.x > playerPos.position.x)
                {
                    body.velocity += Vector2.left * new Vector2(acc * Time.deltaTime, 0);
                }

                if (body.position.x < playerPos.position.x)
                {
                    body.velocity += Vector2.right * new Vector2(acc * Time.deltaTime, 0);
                }
            }
        }
    }
}
