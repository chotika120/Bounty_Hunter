using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject Player1;
    public GameObject Player2;
    public GameObject Player3;
    public GameObject Player4;

    void Start()
    {
        PlayerSpawn();
    }

    void PlayerSpawn()
    {
        Instantiate(Player1, new Vector3(-6, 6, 0), Quaternion.identity);
        Instantiate(Player2, new Vector3(-6, -6, 0), Quaternion.identity);
        Instantiate(Player3, new Vector3(6, -6, 0), Quaternion.identity);
        Instantiate(Player4, new Vector3(6, 6, 0), Quaternion.identity);
    }

}
