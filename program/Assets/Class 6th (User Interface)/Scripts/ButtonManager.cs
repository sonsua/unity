using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    public Text [] buttonText;
    private string[] buttonName = { "START","LOAD","QUIT"};
    // Start is called before the first frame update

    private void Awake()
    {
        for(int i =0; i< buttonName.Length; i++)
        {
            buttonText[i].text= buttonName[i];
        }

    }
    public void GameStart()
    {
        Debug.Log("Start");
    }
    public void GameLoad()
    {
        Debug.Log("Load");
    }
    public void GameQuit()
    {
        Debug.Log("Quit");
    }
}
