using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    [SerializeField]private float speed;

    public int health;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector2.right * Time.deltaTime * speed);
        if(health <= 0)
        {
            Destroy(this.gameObject);
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
