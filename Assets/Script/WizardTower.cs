using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WizardTower : MonoBehaviour {
    [SerializeField]
    private GameObject nameButton, upgradeButton;
    [SerializeField]
    private GameObject bullet;
    [SerializeField]
    private GameObject towerName;
    [SerializeField]
    private GameObject enemy;
    public int price;
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
        attackCooldown = 3f;
        nameButton.GetComponent<NameToggler>().towerName = Instantiate(towerName, transform.position + new Vector3(0, 10), Quaternion.identity, transform);
        upgradeButton.GetComponent<UpgradeButton>().tower = gameObject;
        nameButton.GetComponent<NameToggler>().upgradeButton = Instantiate(upgradeButton, transform.position + new Vector3(8, -8), Quaternion.identity, transform);
        Instantiate(nameButton, transform.position, Quaternion.identity, transform);
    }

    private void Update()
    {
        attackCooldown -= Time.deltaTime;
        if (enemy != null && attackCooldown <= 0)
        {
            if (bullet.GetComponent<Bullet>() != null)
            {
                bullet.GetComponent<Bullet>().enemy = enemy;
            }
            bullet.GetComponent<Bullet>().damage = damage;
            Instantiate(bullet, transform.position, Quaternion.identity);
            attackCooldown = 3f;
        }
    }
}
