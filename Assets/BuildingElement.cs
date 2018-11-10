using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingElement : MonoBehaviour {
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("entered");

        GameObject.Find("GameManager").GetComponent<TankyGameManager>().buildingElements.Remove(gameObject);

        Destroy(gameObject);
    }
}
