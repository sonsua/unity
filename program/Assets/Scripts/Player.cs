using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Player : MonoBehaviour
{

    public Vector3 direction;
    public float speed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        //Boxing : 값 형식의 데이터를 참조 형식으로 변환하는 과정
        object data = speed;

        Debug.Log("data의 값 : " + data);

        float result = (float)data;

        Debug.Log("result 변수의 값 : " + result);

    }

    // Update is called once per frame
    void Update()
    {
        #region Input 클래스
        //if (Input.GetKeyDown(KeyCode.W))
        //{
        //    transform.position += new Vector3(0,0,1);
        //}
        //if (Input.GetKeyDown(KeyCode.S))
        //{
        //    transform.position += new Vector3(0,0,-1);
        //}
        //if (Input.GetKeyDown(KeyCode.A))
        //{
        //    transform.position += new Vector3(-1,0,0);
        //}
        //if (Input.GetKeyDown(KeyCode.D))
        //{
        //    transform.position += new Vector3(1,0,0);
        //}
        #endregion


        #region GetAxis

        direction.x = Input.GetAxisRaw("Horizontal");
        direction.z = Input.GetAxisRaw("Vertical");

        direction.Normalize();//벡터의 정규화

        transform.position += direction * speed * Time.deltaTime;

        #endregion
    }
}
