using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Unit : MonoBehaviour
{
    protected int health;
    protected float attack;
    protected string name;

    public abstract void Move();

}
