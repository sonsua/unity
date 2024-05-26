using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wrairh : Unit
{
    

    // Start is called before the first frame update
    void Start()
    {
        health = 100;
        attack = 20.0f;
        name = "Wraith";
    }

    public override void Move()
    {
        Debug.Log("Wraith Move");
    }
}
