using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public GameObject enemy;

    private float speed;

	// Use this for initialization
	void Start () {
        speed = 10f;
	}
	
	// Update is called once per frame
	void Update () {
        if (enemy != null)
        {
            float x = transform.position.x;
            float y = transform.position.y;
            float xE = enemy.transform.position.x;
            float yE = enemy.transform.position.y;

            if (x <= xE && y <= yE)
            {
                transform.Translate((Vector3.up + Vector3.right) * Time.deltaTime * speed);
            }
            else if (x <= xE && y >= yE)
            {
                transform.Translate((Vector3.down + Vector3.right) * Time.deltaTime * speed);
            }
            else if (x >= xE && y <= yE)
            {
                transform.Translate((Vector3.up + Vector3.left) * Time.deltaTime * speed);
            }
            else if (x >= xE && y >= yE)
            {
                transform.Translate((Vector3.down + Vector3.left) * Time.deltaTime * speed);
            }
        }
        else
        {
            Destroy(gameObject);
        }
       
    }
}
