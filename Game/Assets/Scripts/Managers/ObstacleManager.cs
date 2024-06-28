using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class ObstacleManager : MonoBehaviour
{
    [SerializeField] GameObject[] obstaclePrefabs;

    [SerializeField] List<GameObject> obstacleList;

    [SerializeField] int random;
    [SerializeField] int randomPosition;

    [SerializeField] Transform[] activePosition;

    private void Start()
    {
        obstacleList.Capacity = 10;

        Create();

        StartCoroutine(ActiveObstacle());
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

    public IEnumerator ActiveObstacle()
    {
        WaitForSeconds waitForSeconds = new WaitForSeconds(5f);

        while (true)
        {
            random = Random.Range(0, obstacleList.Count);
            randomPosition = Random.Range(0, activePosition.Length);

            while (obstacleList[random].activeSelf == true)
            {
                if (ExamineActive())
                {
                    GameObject obstacle = Instantiate(obstaclePrefabs[Random.Range(0, activePosition.Length)]);
                    obstacle.SetActive(false);
                    obstacleList.Add(obstacle);
                }

                random = (random +1) % obstacleList.Count;
            }

            obstacleList[random].SetActive(true);

            obstacleList[random].transform.position = activePosition[randomPosition].position;

            yield return CoroutineCache.waitForSeconds(5.0f);
        }
       
    }

    public bool ExamineActive()
    {
        for( int i = 0; i < obstacleList.Count; i++)
        {
            if (obstacleList[i].activeSelf == false)
            {
                return false;
            }
        }
        return true;
    }
}
