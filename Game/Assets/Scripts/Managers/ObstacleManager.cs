using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ObstacleManager : MonoBehaviour
{
    [SerializeField] GameObject[] obstaclePrefabs;

    [SerializeField] List<GameObject> obstacleList;

    [SerializeField] float speed = 1.0f;

    private void Start()
    {
        obstacleList.Capacity = 10;

        Create();
    }


    public void Create()
    {
        for(int i = 0; i < obstaclePrefabs.Length; i++)
        {
            GameObject obstacle = Instantiate(obstaclePrefabs[i]);

            obstacle.SetActive(false);

            obstacleList.Add(obstacle);
        }
    }
}
