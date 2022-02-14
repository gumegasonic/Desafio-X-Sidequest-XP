using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    private GameObject objectToFollow;
    public string objectTag;
    [HideInInspector]
    public GameObject spawnPoint;
    void Start()
    {
        objectToFollow = GameObject.FindGameObjectWithTag(objectTag);
    }

    void Update()
    {
        this.transform.parent = spawnPoint.transform;
        this.transform.position = spawnPoint.transform.Find("Spawner").transform.position;
    }
}
