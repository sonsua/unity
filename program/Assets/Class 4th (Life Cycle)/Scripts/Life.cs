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
    //private void OnEnable()  //게임오브젝트가 활성화되었을때
    //{
    //    Debug.Log("OnEnable");
    //}
    //
    //void Start() //게임오브젝트가 인스턴스된 후에 딱 한 번만, 스크립트가 활성화되었을때
    //{
    //    Debug.Log("Start");
    //}
    //
    //private void FixedUpdate() //TimeStep에 설정된 값에 따라 일정한 간격으로
    //{
    //    Debug.Log("FixedUpdate");
    //}
    //
    //void Update() //매 프레임마다
    //{
    //    Debug.Log("Update");
    //}
    
    private void LateUpdate() //Update가 끝난 후에
    {
        Debug.Log("LateUpdate");
    }

    private void OnDisable() //오브젝트가 비활성화 되었을때
    {
        Debug.Log("OnDisable");
    }

    private void OnDestroy() //오브젝트가 파괴되었을떄
    {
        Debug.Log("OnDestroy");
    }
}
