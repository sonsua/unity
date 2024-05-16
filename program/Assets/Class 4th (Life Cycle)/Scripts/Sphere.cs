using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Item
{
    public int price;
    public string name;
}

public class Sphere : MonoBehaviour
{
    Item item = new Item();

    // Start is called before the first frame update
    void Start()
    {
        item.price = 100;
        item.name = "Sphere Data";

        Debug.Log("item price : "+item.price);
        Debug.Log("item name : " + item.name);
    }

}
