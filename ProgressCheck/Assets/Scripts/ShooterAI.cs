using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterAI : MonoBehaviour
{
    public Transform player;
    public float chaseSpeed = 2.0f;
    public float PaceSpeed = 1.5f;
    public float chaseTriggerDistance = 5.0f;
    Vector3 startPosition;
    bool home = true;
    public Vector3 paceDirection;
    public float paceDistance = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 chaseDirection = new Vector2(player.position.x - transform.position.x, player.position.y - transform.position.y);
        if (chaseDirection.magnitude <= chaseTriggerDistance)
        {
            ChasePlayer();
        }
        else if (!home)
        {
            GoHome();
        }
        else
        {
            Pace();
        }
    }
    void ChasePlayer()
    {
        home = false;
        Vector2 chaseDirection = new Vector2(player.position.x - transform.position.x, player.position.y - transform.position.y);
        chaseDirection.Normalize();
        GetComponent<Rigidbody2D>().velocity = chaseDirection * chaseSpeed;
    }
    void GoHome()
    {
        Vector2 homedirection = new Vector2(startPosition.x - transform.position.x, startPosition.y - transform.position.y);
        if (homedirection.magnitude < .3)
        {
            transform.position = startPosition;
            home = true;
        }
        else
        {
            homedirection.Normalize();
            GetComponent<Rigidbody2D>().velocity = homedirection * PaceSpeed;
        }
    }
    void Pace()
    {
        Vector3 displacement = transform.position - startPosition;
        if (displacement.magnitude >= paceDistance)
        {
            paceDirection = -displacement;
        }
        paceDirection.Normalize();
        GetComponent<Rigidbody2D>().velocity = paceDirection * PaceSpeed;

    }
}

