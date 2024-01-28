using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    [SerializeField] private GameObject shot;
    [SerializeField] private Transform shotPos;
    [SerializeField] private GameObject player;
    [SerializeField] private float maxDistance = 20f;

    private float timer;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        float distance = Vector2.Distance(transform.position, player.transform.position);

        if (distance < maxDistance)
        {
            if (timer > 2)
            {
                timer = 0;
                shoot();
            }
        }

        
    }
    private void shoot()
    {
        Instantiate(shot, shotPos.position, Quaternion.identity);
    }
}
