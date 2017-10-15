using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{

    public GameObject SomePrefab;

    void Update()
    {

        GameObject newPrefab = Instantiate(SomePrefab);
        newPrefab.transform.position = new Vector3(0.0f, 0.0f, 0.0f);

        GameObject newPrefab2 = Instantiate(SomePrefab);
        newPrefab.transform.position = new Vector3(10.0f, 10.0f, 0.0f);



    }
}
