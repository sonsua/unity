using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum RoadLine
{
    LEFT   = -1,
    MIDDLE = 0,
    RIGHT  = 1, 
}

public class Runner : MonoBehaviour
{
    [SerializeField] Animator animator;

    [SerializeField] RoadLine roadLine;
    [SerializeField] float positionX = 3.5f;

    // Start is called before the first frame update
    void Start()
    {
        roadLine = RoadLine.MIDDLE;
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
            if(roadLine != RoadLine.LEFT) {
                roadLine--;
                animator.Play("Left Move");
            }    
            }
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
            if (roadLine != RoadLine.RIGHT)
            {
                roadLine++;
                animator.Play("Right Move");
            }
        }
        Status(roadLine);
    }

    public void Status(RoadLine roadLine)
    {
        switch (roadLine)
        {
            case RoadLine.LEFT: Move(-positionX);
                Debug.Log("Left");
                break;
            case RoadLine.MIDDLE: Move(0);
                Debug.Log("Middle");
                break;
            case RoadLine.RIGHT: Move(positionX);
                Debug.Log("Right");
                break;
        }
    }

    public void Move(float positionX)
    {
        transform.position = new Vector3(positionX, 0, 0);
    }
}
