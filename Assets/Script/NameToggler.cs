using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NameToggler : MonoBehaviour {

    public bool clicked;

    public GameObject towerName, upgradeButton;

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
            if(upgradeButton != null)
                upgradeButton.SetActive(false);
            towerName.SetActive(false);
        }
        else if (clicked)
        {
            clicked = false;
            if (upgradeButton != null)
                upgradeButton.SetActive(true);
            towerName.SetActive(true);
        }
    }
}
