using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowBullet : MonoBehaviour {

    public Transform enemy;
    private Vector2 target;
    private float speed;
    private float timer=0;
    // Use this for initialization
    void Start()
    {
        enemy = GameObject.FindGameObjectWithTag("Enemy").transform;
        target = new Vector2(enemy.position.x, enemy.position.y);
        speed = 10f;
    }

    // Update is called once per frame
    void Update()
    {
        //Utk chase target di posisi mana dia pas terkena scanning 
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);
        //Utk timer bullet menghilang jika lebih dari 6 detik
        timer += Time.deltaTime;
        if (timer >= 6)
        {
            Destroy(gameObject);
            timer = 0;
        }
        //if (enemy != null)
        //{
        //    transform.position = Vector2.MoveTowards(transform.position, enemy.transform.position, speed * Time.deltaTime);
        //}
        //else
        //{
        //    Destroy(gameObject);
        //}

    }
    public void OnTriggerEnter2D(Collider2D collide)
    {
        if (collide.tag == "Enemy")
        {
            Destroy(gameObject);
        }
    }
}
