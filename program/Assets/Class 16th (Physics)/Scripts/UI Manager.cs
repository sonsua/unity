using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text resultText;

    public void Result(string resultName)
    {
        resultText.gameObject.SetActive(true);
        resultText.text = resultName;
    }
}
