using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public enum RoadLine
{
    LEFT   = -1,
    MIDDLE = 0,
    RIGHT  = 1, 
}

[RequireComponent(typeof(Rigidbody))]

public class Runner : State
{
    [SerializeField] Animator animator;
    [SerializeField] AudioClip sound;

    [SerializeField] RoadLine roadLine;
    [SerializeField] float positionX = 3.5f;
    [SerializeField] float speed = 5.0f;

    [SerializeField] RoadLine PreviousLine;


    private void OnEnable()
    {
        base.OnEnable();
        InputManager.Instance.keyAction += OnKeyUpdate;
    }

    public void RevertPosition()
    {
        roadLine = PreviousLine;
    }

    // Start is called before the first frame update
    void Awake()
    {
        roadLine = RoadLine.MIDDLE;
        PreviousLine = RoadLine.MIDDLE;

        animator = GetComponent<Animator>();

        Initioalize();
    }

    public void Initioalize()
    {
        animator.speed = SpeedManager.Speed / 20;
    }
    void OnKeyUpdate()
    {
        if (state == false) return;

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

    private void OnTriggerEnter(Collider other)
    {
        IHitable hitable = other.GetComponent<IHitable>();

        if (hitable != null)
        {
            hitable.Activate(this);
        }
    }

    public void Die()
    {
        animator.Play("Die");
    }

    void Update()
    {
        if (state == false) return;
        Move();
    }

    public void Move()
    {
        if (state == false) return;
        transform.position = Vector3.Lerp(transform.position, new Vector3(positionX * (float)roadLine, 0, 0), speed*Time.deltaTime);
    }

    private void OnDisable()
    {
        base.OnDisable();
        InputManager.Instance.keyAction -= OnKeyUpdate;
    }
}
