using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemolishTower : MonoBehaviour {

    public GameObject tower;
    private GameObject land;
    public bool destroyed;

    public void Start()
    {
        destroyed = true;
    }
    // Update is called once per frame
    public void Demolish() {
        if (tower != null)
        {
            Destroy(tower);
            destroyed = true;
        }
        Destroy(gameObject);
    }

}
