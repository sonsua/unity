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
        //현재 플레이어가 나 자신이라면
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
