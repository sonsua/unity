using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Capsule : MonoBehaviour
{
    private float health;
    private float MaxHealth;

    public Slider slider;

    void Start()
    {
        health = 100;
        MaxHealth = health;
    }

    public void Damage(float damage)
    {
        if (health > 0)
        {
            health -= damage;
            slider.value = health / MaxHealth;
        }

    }
}
