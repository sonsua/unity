using Photon.Pun;
using Photon.Realtime;
using UnityEngine;

public class GameManager : MonoBehaviourPunCallbacks
{
    private void Awake()
    {
        Create();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Create()
    {
        PhotonNetwork.Instantiate(
            "Charactor",
            RandomPosition(5),
            Quaternion.identity
            );
    }

    public Vector3 RandomPosition(int value)
    {
        Vector3 direcrion = Random.insideUnitSphere;

        direcrion.Normalize();

        direcrion *= value;
        direcrion.y = 1;

       return direcrion;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
