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

    private void OnEnable()
    {
        InputManager.Instance.keyAction += OnKeyUpdate;
    }

    // Start is called before the first frame update
    void Start()
    {
        roadLine = RoadLine.MIDDLE;
        animator = GetComponent<Animator>();
    }

    void OnKeyUpdate()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (roadLine != RoadLine.LEFT)
            {
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
    }

    // Update is called once per frame
    void Update()
    {         
        Move();
    }

    public void Move()
    {
        transform.position = new Vector3(positionX*(float)roadLine, 0, 0);
    }

    private void OnDisable()
    {
        InputManager.Instance.keyAction -= OnKeyUpdate;
    }
}
