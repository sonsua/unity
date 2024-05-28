using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Earth : MonoBehaviour
{

    void Update()
    {
        transform.rotation = Quaternion.Euler(10,10,10);
    }

}
