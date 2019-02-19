using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Land : MonoBehaviour {

    [SerializeField] private GameObject tower;

    public bool isEmpty;

    private void Start()
    {
        isEmpty = true;
    }

    private void OnMouseOver()
    {
        if(Input.GetMouseButtonDown(0) && isEmpty)
        {
            Instantiate(tower, transform.position, Quaternion.identity,gameObject.transform);
            isEmpty = false;
        }
    }
}
