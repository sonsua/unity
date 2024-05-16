using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aj : MonoBehaviour
{
    public int[] data;

    private void Start()
    {
        foreach (int element in data)
        {
            Debug.Log(element);
        }
    }
}
