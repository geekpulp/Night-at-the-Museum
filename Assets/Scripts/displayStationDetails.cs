using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class displayStationDetails : MonoBehaviour {

    //var
	public GameObject boom;

    public void Headset() {
			boom.SetActive(!boom.activeInHierarchy);
			Debug.Log("testing my method is being called");
    }

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		
	}
}
