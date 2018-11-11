using Complete;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Barrier : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        GameObject.Find("Died").GetComponent<Text>().text = "Vesztettél!";
        GameObject.Find("Level").GetComponent<Text>().text = "";
        //targetHealth.TakeDamage(0);

        GameObject tank = GameObject.Find("CompleteTank");
        if(tank.GetComponent<TankHealth>() != null)
        {
            TankHealth tankHealth = tank.GetComponent<TankHealth>();
            tankHealth.TakeDamage(100);
        } else
        {
            Debug.Log("Missing TankHealth");
        }
        
    }
}