using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgrade : MonoBehaviour {

    public float towerDamage;
    public float attackCooldown;
    private float level;

    private void Start()
    {
        level = 1;
    }

    private void Update()
    {
        if(level >=5 )
        {
            Destroy(gameObject);
        }
    }

    public void Up()
    {
        towerDamage += 1;
        attackCooldown -= 0.5f;
        level++;
    }
}
