using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    private Ray ray;
    public LayerMask layerMask;
    private RaycastHit rayCastHit;

    // Update is called once per frame
    void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Input.GetButtonDown("Fire1"))
        {
            //Physics.Raycast
            //ray : ������ ���� ����
            //rayCastHit : �浹�� ������Ʈ�� ���� ����
            //Mathf.Infinity : ������ ����
            // layerMask : �浹 ������ ���̾�
            if (Physics.Raycast(ray, out rayCastHit, Mathf.Infinity, layerMask))
            {
                rayCastHit.collider.GetComponent<Health>().HP -= 10;
                Debug.Log(rayCastHit.collider.GetComponent<Health>().HP);
            }
        }
    }
}
