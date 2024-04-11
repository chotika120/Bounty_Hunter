using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Player : MonoBehaviour
{
    public GameObject Player1;
    // public GameObject Player2;
    // public GameObject Player3;
    // public GameObject Player4;

    public Tilemap tilemap;

    void Start()
    {
        PlayerSpawn();
    }

    void PlayerSpawn()
    {
        Vector3 P1_Position = tilemap.GetCellCenterWorld(new Vector3Int(0, 12, 0));
        // Vector3 P2_Position = tilemap.GetCellCenterWorld(new Vector3Int(0, 0, 0));
        // Vector3 P3_Position = tilemap.GetCellCenterWorld(new Vector3Int(12, 0, 0));
        // Vector3 P4_Position = tilemap.GetCellCenterWorld(new Vector3Int(12, 12, 0));

        Instantiate(Player1, P1_Position, Quaternion.identity);
        // Instantiate(Player2, P2_Position, Quaternion.identity);
        // Instantiate(Player3, P3_Position, Quaternion.identity);
        // Instantiate(Player4, P4_Position, Quaternion.identity);
    }
    
}
