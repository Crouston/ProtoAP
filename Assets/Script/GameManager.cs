using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    [SerializeField] private GameObject enemy;

    [SerializeField]private Vector3 spawnPoint;
    //int counter = 0;
    private float spawnCooldown;

	// Use this for initialization
	void Start () {
        spawnCooldown = 2f;
	}
	
	// Update is called once per frame
	void Update () {
        spawnCooldown -= Time.deltaTime;
        if(spawnCooldown <= 0)
        {
            Instantiate(enemy,spawnPoint,Quaternion.identity);
            spawnCooldown = 2f;
            //counter++;
        }
        //if (counter >= 3)
        //    spawnCooldown = 15f;
	}
}
