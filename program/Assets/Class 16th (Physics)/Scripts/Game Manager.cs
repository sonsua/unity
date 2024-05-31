using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private bool state = true;

    public bool State
    {
        set { state = value; }
        get { return state; }
    }


}
