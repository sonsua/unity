using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{
    //private void Awake()
    //{
    //    Debug.Log("Awake");
    //}
    //
    //private void OnEnable()  //���ӿ�����Ʈ�� Ȱ��ȭ�Ǿ�����
    //{
    //    Debug.Log("OnEnable");
    //}
    //
    //void Start() //���ӿ�����Ʈ�� �ν��Ͻ��� �Ŀ� �� �� ����, ��ũ��Ʈ�� Ȱ��ȭ�Ǿ�����
    //{
    //    Debug.Log("Start");
    //}
    //
    //private void FixedUpdate() //TimeStep�� ������ ���� ���� ������ ��������
    //{
    //    Debug.Log("FixedUpdate");
    //}
    //
    //void Update() //�� �����Ӹ���
    //{
    //    Debug.Log("Update");
    //}
    
    private void LateUpdate() //Update�� ���� �Ŀ�
    {
        Debug.Log("LateUpdate");
    }

    private void OnDisable() //������Ʈ�� ��Ȱ��ȭ �Ǿ�����
    {
        Debug.Log("OnDisable");
    }

    private void OnDestroy() //������Ʈ�� �ı��Ǿ�����
    {
        Debug.Log("OnDestroy");
    }
}
