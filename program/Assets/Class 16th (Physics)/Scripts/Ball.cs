using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private float speed = 5.0f;
    private Rigidbody rigidbody;
    private Vector3 direction;

    public GameManager gameManager;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();  
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager.State == false) { 
            
            rigidbody.freezeRotation = true;
            return;
        }

        direction.x = Input.GetAxisRaw("Horizontal");
        direction.z = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        if (gameManager.State == false)
        {
            return;
        }
        //Impulse : ¼ø°£ÀûÀÎ Èû
        rigidbody.AddForce(direction*speed*Time.fixedDeltaTime, ForceMode.Impulse);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision Enter");
    }

    private void OnCollisionStay(Collision collision) 
    {
        Debug.Log("Collision Stay");
    }
    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("Collision Exit");
    }
}
