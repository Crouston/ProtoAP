using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NameToggler : MonoBehaviour {

    public bool clicked;

    public GameObject towerName;

    // Use this for initialization
    void Start () {
        clicked = false;
	}
	
	// Update is called once per frame
	void Update () {
        
    }

    public void NameToggle()
    {
        if (!clicked)
        {
            clicked = true;
            towerName.SetActive(false);
        }
        else if (clicked)
        {
            clicked = false;
            towerName.SetActive(true);
        }
    }
}
