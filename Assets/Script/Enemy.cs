using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    private bool isHitSlow= false;
    private float timer;

    public int health;

    // Array of waypoints to walk from one to the next one
    public Transform waypoints;

    // Walk speed that can be set in Inspector
    [SerializeField]
    private float moveSpeed = 2f;
    
	// Update is called once per frame
	void Update () {
       // transform.Translate(Vector2.right * Time.deltaTime * speed);
        Move();
        if(health <= 0)
        {
            Destroy(this.gameObject);
        }
        if (isHitSlow == true)
        {
            slowDelay();
        }
	}
    private void Move()
    {
        transform.position = Vector2.MoveTowards(transform.position,
        waypoints.transform.position,
        moveSpeed * Time.deltaTime);
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bullet")
        {
            health -= 1;
            Destroy(collision.gameObject);
        }
        if(collision.tag == "End")
        {
            health = 0;
        }
        if (collision.tag == "SlowBullet")
        {
            isHitSlow = true;
        }
    }
    private void slowDelay()
    {
        timer += Time.deltaTime;
        if (timer < 2)
        {
            moveSpeed = 5f;
        }
        else
        {
            moveSpeed = 15f;
            isHitSlow = false;
        }

    }
}
