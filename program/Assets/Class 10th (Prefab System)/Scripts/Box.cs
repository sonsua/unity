using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

public class Box : MonoBehaviour
{

    public int x = 1;
    public int y = 1;
    public int z = 1;

    void Update()
    {
        transform.Rotate(x*Time.deltaTime, y * Time.deltaTime, z * Time.deltaTime);
    }
 
}
