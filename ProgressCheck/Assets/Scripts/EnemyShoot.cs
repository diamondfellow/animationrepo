﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public GameObject prefab;
    public float bspee = 8f;
    public float bulletlifetime = 3f;
    public float shhotdelay = 5f;
    float timer = 0f;
    public float shootTriggerDistance = 10.0f;
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        Vector2 shootdire = new Vector2(player.position.x - transform.position.x, player.position.y - transform.position.y);
        if (timer > shhotdelay && shootdire.magnitude < shootTriggerDistance)
        {

            GameObject bullet = Instantiate(prefab, transform.position, Quaternion.identity);
                                               
            
            shootdire.Normalize();
            bullet.GetComponent<Rigidbody2D>().velocity = shootdire * bspee;
            Destroy(bullet, bulletlifetime);
            timer = 0f;



        }
    }
}

