using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Land : MonoBehaviour {
    //[SerializeField]
    //private GameObject towerName;
    [SerializeField] private GameObject tower;
    public GameObject aoetower;
    [SerializeField]
    private GameObject wizard;
    public bool isEmpty;

    private void Start()
    {
        isEmpty = true;
    }

    
    public void CreateTower()
    {
        if(isEmpty)
        {
            //Instantiate(wizard, transform.position, Quaternion.identity, gameObject.transform);
            //Instantiate(aoetower, transform.position, Quaternion.identity, gameObject.transform);
            Instantiate(tower, transform.position, Quaternion.identity,gameObject.transform);
            isEmpty = false;          
        }

    }
    
}
