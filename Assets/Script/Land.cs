using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Land : MonoBehaviour {
    //[SerializeField]
    //private GameObject towerName;
    public int choice = 0;
    [SerializeField] private GameObject tower;
    public GameObject aoetower;
    [SerializeField]
    private GameObject wizard;
    public bool isEmpty;

    private void Start()
    {
        isEmpty = true;
    }
    public void choice1()
    {
        choice = 1;
    }
    public void choice2()
    {
        choice = 2;
    }
    public void choice3()
    {
        choice = 3;
    }
   
    public void CreateTower()
    {
        if(isEmpty)
        {
            if (choice == 1)
            {
                Instantiate(wizard, transform.position, Quaternion.identity, gameObject.transform);
                choice = 0;
                isEmpty = false;
            }
            else if (choice == 2)
            {
                Instantiate(aoetower, transform.position, Quaternion.identity, gameObject.transform);
                choice = 0;
                isEmpty = false;
            }
            else if (choice == 3)
            {
                Instantiate(tower, transform.position, Quaternion.identity, gameObject.transform);
                choice = 0;
                isEmpty = false;
            }
        }

    }
    public void ResetChoice()
    {
        choice = 0;
    }
    
}
