using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AoE_Tower : MonoBehaviour {

    [SerializeField]
    private GameObject bullet;
    [SerializeField]
    private GameObject towerName;

    [SerializeField]
    private GameObject nameButton;

    [SerializeField]
    private GameObject enemy;

    private float attackCooldown;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (enemy == null && collision.tag == "Enemy")
        {
            enemy = collision.gameObject;
        }
    }

    private void Start()
    {
        attackCooldown = 3f;
        nameButton.GetComponent<NameToggler>().towerName = Instantiate(towerName, transform.position + new Vector3(0, 10), Quaternion.identity, transform);
        Instantiate(nameButton, transform.position, Quaternion.identity, transform);
    }

    private void Update()
    {
        attackCooldown -= Time.deltaTime;
        if (enemy != null && attackCooldown <= 0)
        {
           // bullet.GetComponent<SlowBullet>().enemy = enemy;
            Instantiate(bullet, transform.position, Quaternion.identity);
            attackCooldown = 3f;
        }
    }
}
