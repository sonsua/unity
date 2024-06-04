using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    private int coin;

   public void Load()
    {
        coin = PlayerPrefs.GetInt("Coin");
    }

    public void SetData()
    {
        coin += 100;
        PlayerPrefs.SetInt("Coin", coin);
    }
}
