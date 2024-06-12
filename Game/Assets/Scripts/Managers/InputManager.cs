using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public Action keyAction;

    // Update is called once per frame
    void Update()
    {
        if(Input.anyKey == false)
        {
            return;
        }
        if(keyAction != null)
        {
            keyAction.Invoke();
        }
    }

}
