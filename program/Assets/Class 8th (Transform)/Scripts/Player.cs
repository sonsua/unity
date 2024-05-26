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
        //Boxing : �� ������ �����͸� ���� �������� ��ȯ�ϴ� ����
        object data = speed;

        Debug.Log("data�� �� : " + data);

        float result = (float)data;

        Debug.Log("result ������ �� : " + result);

    }

    // Update is called once per frame
    void Update()
    {
        #region Input Ŭ����
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

        direction.Normalize();//������ ����ȭ

        transform.position += direction * speed * Time.deltaTime;

        #endregion
    }
}
