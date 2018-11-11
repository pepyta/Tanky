using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class TankyGameManager : MonoBehaviour {

    [SerializeField] GameObject m_buildingLevel;
    [SerializeField] GameObject m_barriers;
    [SerializeField] GameObject m_barrierSideway;
    [SerializeField] Material m_Material1;
    [SerializeField] Material m_Material2;
    [SerializeField] Text levelText;
    [SerializeField] public List<GameObject> buildingElements = new List<GameObject>();

    [SerializeField] int level = 0;
    float distance;
    Material choosenMaterial;

    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if(buildingElements.Count == 0)
        {
            level++;
            levelText.text = level + ". szint";
            Destroy(GameObject.Find("Barriers(Clone)"));
            InitializeLevel(level);
        }
	}

    void InitializeBuilding(int levels, int levelOfGame)
    {
        for(int i = 0; i < levels; i++)
        {
            if(i % 2 == 0){
                choosenMaterial = m_Material1;
            } else {
                choosenMaterial = m_Material2;
            }

            if(-30f + levelOfGame > 0){
                distance = 0;
            } else {
                distance = -30f + levelOfGame;
            }

            m_buildingLevel.GetComponent<Transform>().position = new Vector3(0, i*2+1, distance);
            m_buildingLevel.GetComponent<Renderer>().material = choosenMaterial;
            var realObject = Instantiate(m_buildingLevel);

            buildingElements.Add(realObject);

        }
    }

    void InitializeLevel(int level)
    {
        if (-30f + level > 0)
        {
            distance = 0;
        } else {
            distance = -30f + level;
        }
        InitializeBuilding(1 + level, level);

        if (level > 3)
        {
            m_barriers.GetComponent<Transform>().position = new Vector3(0, 0, distance);
            Instantiate(m_barriers);
        }

        if (level / 7 > 0)
        {
            if(level % 7 == 0)
            {
                //Vector3 position = m_barrierSideway.GetComponent<Transform>().position;
                float zPos = -42.7f + (level - 2f);
                m_barrierSideway.GetComponent<Transform>().position = new Vector3(-2.5f, 2.5f, zPos);
                Debug.Log(zPos);
                Debug.Log(level);
                Instantiate(m_barrierSideway);
            }
        }

    }
}
