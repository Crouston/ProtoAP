using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Land : MonoBehaviour {
    //[SerializeField]
    //private GameObject towerName;
    public bool isEmpty;

    private void Start()
    {
        isEmpty = true;
    }
   
   
    public void CreateTower()
    {
        if(isEmpty && GameManager.FindObjectOfType<GameManager>().selectedWizard != null)
        {
            Instantiate(GameManager.FindObjectOfType<GameManager>().selectedWizard, transform.position, Quaternion.identity, transform);
            isEmpty = false;
            GameManager.FindObjectOfType<GameManager>().selectedWizard = null;
        }

    }
   
    
}
