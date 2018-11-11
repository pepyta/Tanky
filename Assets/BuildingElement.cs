using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingElement : MonoBehaviour {
    float xPos;
    float zPos;
    // Use this for initialization
    void Start () {
        Physics.IgnoreLayerCollision(10, 11);
    }
    void Awake()
    {
        xPos = transform.position.x;
        zPos = transform.position.z;
    }
    // Update is called once per frame
    void Update () {
        transform.position = new Vector3(xPos, transform.position.y, zPos);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("entered");

        GameObject.Find("GameManager").GetComponent<TankyGameManager>().buildingElements.Remove(gameObject);

        Destroy(gameObject);
    }
}
