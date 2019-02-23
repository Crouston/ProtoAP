using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Land : MonoBehaviour {
    [SerializeField]
    private GameObject text;
    [SerializeField] private GameObject tower;
    [SerializeField]
    private GameObject wizard;
    public bool isEmpty;

    private void Start()
    {
        isEmpty = true;
    }

    
    private void OnMouseDown()
    {
        if(isEmpty)
        {
            Instantiate(wizard, transform.position, Quaternion.identity, gameObject.transform);

            Instantiate(tower, transform.position, Quaternion.identity,gameObject.transform);
            isEmpty = false;
            text.SetActive(true);          //  Instantiate(text, transform.position, Quaternion.identity, gameObject.transform);
        }

    }
    
}
