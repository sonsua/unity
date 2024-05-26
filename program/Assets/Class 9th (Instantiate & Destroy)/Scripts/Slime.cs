using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime : Unit
{
  

    // Start is called before the first frame update
    void Start()
    {
        health = 75;
        attack = 10.0f;
        name = "Slime";
    }

    public override void Move()
    {
        Debug.Log("Slime Move");
    }
}
