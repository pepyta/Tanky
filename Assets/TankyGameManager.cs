using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankyGameManager : MonoBehaviour {

    [SerializeField] GameObject m_buildingLevel;
    [SerializeField] Material m_Material1;
    [SerializeField] Material m_Material2;

    [SerializeField] public List<GameObject> buildingElements = new List<GameObject>();

    int level = 1;
    Material choosenMaterial;

    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if(buildingElements.Count == 0)
        {
            level++;
            InitializeLevel(level);
        }
	}

    void InitializeBuilding(int levels, int levelOfGame)
    {
        for(int i = 0; i < levels; i++)
        {
            if(i % 2 == 0)
            {
                choosenMaterial = m_Material1;
            }
            else
            {
                choosenMaterial = m_Material2;
            }
            m_buildingLevel.GetComponent<Transform>().position = new Vector3(28.15f - levelOfGame, i*2+1, 12.36f);
            m_buildingLevel.GetComponent<Renderer>().material = choosenMaterial;
            var realObject = Instantiate(m_buildingLevel);

            buildingElements.Add(realObject);

        }
    }

    void InitializeLevel(int level)
    {
        InitializeBuilding(1 + level, level);
    }
}
