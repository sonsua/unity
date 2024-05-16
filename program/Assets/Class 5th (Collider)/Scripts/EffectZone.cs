using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDamageable
{
    void Active();
}

public class EffectZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Other Cube")
        {
            Debug.Log("OnTriggerEnter");
        }
        
    }
    private void OnTriggerSeay(Collider other)
    {
        if (other.tag == "Other Cube")
        {
            Debug.Log("OnTriggerStay");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Other Cube")
        {
            Debug.Log("OnTriggerExit");
        }
    }

    
}
