using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SpawnData
{
    public GameObject Prefab;
    public Vector3 Position;
}

public class Spawner : MonoBehaviour
{
    public List<SpawnData> Data;

	// Use this for initialization
	void Start ()
    {
		foreach (SpawnData d in Data)
        {
            GameObject newPrefab = Instantiate(d.Prefab);
            newPrefab.transform.position = d.Position;
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
