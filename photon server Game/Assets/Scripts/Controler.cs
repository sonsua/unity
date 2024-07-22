using Photon.Pun;
using TMPro;
using UnityEngine;

public class Controler : MonoBehaviourPun
{
    [SerializeField] float mouseX;
    [SerializeField] float speed;

    [SerializeField] Vector3 direction;
    [SerializeField] Camera temporaryCamera;

    // Start is called before the first frame update
    void Start()
    {
        //���� �÷��̾ �� �ڽ��̶��
        if (photonView.IsMine)
        {
            Camera.main.gameObject.SetActive(false);
        }
        else
        {
            temporaryCamera.enabled = false;
            GetComponent<AudioListener>().enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
