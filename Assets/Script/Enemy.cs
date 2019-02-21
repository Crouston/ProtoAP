using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    
    

    public int health;

    // Array of waypoints to walk from one to the next one
    [SerializeField]
    private Transform[] waypoints;

    // Walk speed that can be set in Inspector
    [SerializeField]
    private float moveSpeed = 2f;

    // Index of current waypoint from which Enemy walks
    // to the next one
    private int waypointIndex = 0;

    

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
       // transform.Translate(Vector2.right * Time.deltaTime * speed);
        Move();
        if(health <= 0)
        {
            Destroy(this.gameObject);
        }
	}
    private void Move()
    {

        if (waypointIndex <= waypoints.Length - 1)
        {


            transform.position = Vector2.MoveTowards(transform.position,
               waypoints[waypointIndex].transform.position,
               moveSpeed * Time.deltaTime);


            if (transform.position == waypoints[waypointIndex].transform.position)
            {
                waypointIndex += 1;

            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bullet")
        {
            health -= 1;
            Destroy(collision.gameObject);
        }
    }
}
