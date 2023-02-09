using UnityEngine;
using System.Collections;
using System;
using Random = UnityEngine.Random;
public class FallingObjects : MonoBehaviour
{
    public GameObject target;

    void Start()
    {
        InvokeRepeating("SpawnObject", 0.5f, 1.5f);
    }

    void SpawnObject()
    {
        float x = Random.Range(-1283.0f, 972f);
        float z = Random.Range(1013f, 1014f);
        Instantiate(target, new Vector3(x, z, 639f), Quaternion.identity);
    }
}
