using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    private int hp = 100;

    public int HP
    {
        get { return hp; }
        set { hp = value; }
    }
    
}
