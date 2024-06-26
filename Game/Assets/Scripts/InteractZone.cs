using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        IInterectable interectable = other.GetComponent<IInterectable>();

        if(interectable != null)
        {
            interectable.Interact();
        }
    }
}
