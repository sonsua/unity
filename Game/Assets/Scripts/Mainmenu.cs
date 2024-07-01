using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mainmenu : MonoBehaviour
{
public void Execute()
    {
        EventManager.Publish(EventType.START);

        StartCoroutine(SceneControler.Instance.AsyncLoad(1));
    }
}
