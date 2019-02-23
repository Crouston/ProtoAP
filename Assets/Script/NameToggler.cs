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

    private void OnMouseDown()
    {
        if (!clicked)
        {
            towerName.SetActive(false);
            clicked = true;
        }
        else if (clicked)
        {
            towerName.SetActive(true);
            clicked = false;
        }
    }
}
