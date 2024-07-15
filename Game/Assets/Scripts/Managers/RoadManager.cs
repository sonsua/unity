using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RoadManager : State
{
    [SerializeField] List<GameObject> roads;
    [SerializeField] float offset = 20.0f;
    [SerializeField] float speed;

    private void Awake()
    {
        DontDestroyOnLoad(this);
    }

    private void Start()
    {
        roads.Capacity = 10;
    }

    public void Initialize()
    {
        speed = SpeedManager.Speed / 2;
    }

    private void Update()
    {
        if (state == false) return;

        for (int i = 0; i < roads.Count; i++)
        {
            roads[i].transform.Translate(Vector3.back * speed * Time.deltaTime);
        }

    }

    public void NewPosition()
    {
        GameObject newRoad = roads[0];

        roads.Remove(newRoad);

        float newZ = roads[roads.Count - 1].transform.position.z + offset;

        newRoad.transform.position = new Vector3(0, 0, newZ);

        roads.Add(newRoad);
    }

    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        Initialize();
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
}
