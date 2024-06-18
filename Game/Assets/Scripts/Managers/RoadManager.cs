using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadManager : Singleton<RoadManager>
{
    [SerializeField] List<GameObject> roads;
    [SerializeField] float roadSpeed = 1;

    private void Start()
    {
        roads.Capacity = 10;
    }

    private void Update()
    {
        for(int i = 0; i < roads.Count; i++)
        {
            roads[i].transform.Translate(Vector3.back * roadSpeed * Time.deltaTime);
        }

    }
}
