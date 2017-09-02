using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class displayStationDetails : MonoBehaviour {

    //var
	public GameObject selecteditem;

    
	// method for action on headset station click
	public void Headset() {
		selecteditem.SetActive(!selecteditem.activeInHierarchy);
			Debug.Log("testing my method is being called");
    }

		
}
