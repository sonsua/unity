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
    [SerializeField] AudioClip sound;

    [SerializeField] RoadLine roadLine;
    [SerializeField] float positionX = 3.5f;
    [SerializeField] float speed = 5.0f;

    [SerializeField] RoadLine PreviousLine;


    private void OnEnable()
    {
        InputManager.Instance.keyAction += OnKeyUpdate;
    }

    public void RevertPosition()
    {
        roadLine = PreviousLine;
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
            PreviousLine = roadLine;

            if (roadLine != RoadLine.LEFT)
            {
                roadLine--;

                SoundManager.Instance.Sound(sound);

                animator.Play("Left Move");

            }
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            PreviousLine = roadLine;

            if (roadLine != RoadLine.RIGHT)
            {
                roadLine++;

                SoundManager.Instance.Sound(sound);

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
        transform.position = Vector3.Lerp(transform.position, new Vector3(positionX * (float)roadLine, 0, 0), speed*Time.deltaTime);
    }

    private void OnDisable()
    {
        InputManager.Instance.keyAction -= OnKeyUpdate;
    }
}
