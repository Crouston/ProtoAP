﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AoE_Tower : MonoBehaviour {

    [SerializeField]
    private GameObject bullet;
    [SerializeField]
    private GameObject towerName;

    [SerializeField]
    private GameObject nameButton, upgradeButton, demolishButton;

    [SerializeField]
    private GameObject enemy;
    

    public float damage;

    public float attackCooldown;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (enemy == null && collision.tag == "Enemy")
        {
            enemy = collision.gameObject;
        }
    }

    private void Start()
    {
        enemy = null;
        attackCooldown = 3f;
        nameButton.GetComponent<NameToggler>().towerName = Instantiate(towerName, transform.position + new Vector3(0, 10), Quaternion.identity, transform);
        upgradeButton.GetComponent<UpgradeButton>().tower = gameObject;
        nameButton.GetComponent<NameToggler>().upgradeButton = Instantiate(upgradeButton, transform.position+new Vector3(8,-8), Quaternion.identity, transform);
        demolishButton.GetComponent<DemolishTower>().tower = gameObject;
        nameButton.GetComponent<NameToggler>().demolishButton = Instantiate(demolishButton, transform.position + new Vector3(4, -8), Quaternion.identity, transform);
        Instantiate(nameButton, transform.position, Quaternion.identity, transform);
    }

    private void Update()
    {
        attackCooldown -= Time.deltaTime;
        if (enemy != null && attackCooldown <= 0)
        {
            bullet.GetComponent<AoE_Bullet>().enemy = enemy.transform;
            bullet.GetComponent<AoE_Bullet>().damage = damage;
            Instantiate(bullet, transform.position, Quaternion.identity);
            attackCooldown = 3f;
        }
    }
}
