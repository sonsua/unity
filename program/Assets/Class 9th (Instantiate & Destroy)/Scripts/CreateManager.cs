using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CreateManager : MonoBehaviour
{
    public Factory factory;

    // Start is called before the first frame update
    private void Awake()
    {
        factory = GetComponent<Factory>();
    }

    private void Start()
    {
        //invoke() : 특정한 시간마다 함수를 호출하는 함수
        
        InvokeRepeating(nameof(Use), 1,5);
    }

    public void Use()
    {
        int select = Random.Range(0, 2);
        factory.Create((UnitType)select);
    }
}
