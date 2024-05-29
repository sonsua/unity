using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    WaitForSeconds WaitForSeconds = new WaitForSeconds(3);

    void Start()
    {
        StartCoroutine(Routine());
    }

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) {
            StopAllCoroutines();
        }
    }

    public IEnumerator Routine()
    {
        while (true)
        {
            Debug.Log("Start");

            yield return WaitForSeconds;

            Debug.Log("Coroutine");
        }
    }
}
