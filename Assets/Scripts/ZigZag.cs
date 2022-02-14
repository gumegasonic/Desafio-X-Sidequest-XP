using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZigZag : MonoBehaviour
{
    public bool waitForPlayer;
    public Transform pos1, pos2;
    public float speed;
    public Transform startPos;
    public Collider2D playerDetector;
    private Collider2D playerCollider;
    public LayerMask player;
    private Rigidbody2D rb;
    private float direction = 1;

    Vector2 nextPos;
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        nextPos = startPos.position;
    }

    void FixedUpdate()
    {
        playerCollider = Physics2D.OverlapBox(playerDetector.bounds.center, playerDetector.bounds.size, 0, player);

        if (waitForPlayer)
        {
            if (playerCollider && playerCollider.CompareTag("Player"))
            {
                transform.position = Vector2.MoveTowards(transform.position, nextPos, speed * Time.deltaTime);
            }
        }
        else
        {
            rb.velocity = new Vector2(speed * direction, rb.velocity.y);
        }

        if (transform.position.x <= pos1.position.x)
        {
            nextPos = pos2.position;
            direction = 1;
        }
        if (transform.position.x >= pos2.position.x)
        {
            nextPos = pos1.position;
            direction = -1;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(pos1.position, pos2.position);
    }
}