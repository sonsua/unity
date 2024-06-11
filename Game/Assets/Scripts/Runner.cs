using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum RoadLine
{
    LEFT   = -1, //0
    MIDDLE = 0, //1
    RIGHT  = 1,  //2
}

public class Runner : MonoBehaviour
{
    [SerializeField] RoadLine roadLine;
    [SerializeField] float positionX = 3.5f;

    // Start is called before the first frame update
    void Start()
    {
        roadLine = RoadLine.MIDDLE;
    }

    // Update is called once per frame
    void Update()
    {
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
            if(roadLine != RoadLine.LEFT) {
                roadLine--;
            }    
            }
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
            if (roadLine != RoadLine.RIGHT)
            {
                roadLine++;
            }
        }
    }
}
