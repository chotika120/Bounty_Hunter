using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Player : MonoBehaviour
{
    public GameObject Player1;
    public GameObject Player2;
    public GameObject Player3;
    public GameObject Player4;

    public Tilemap tilemap; 

    void Start()
    {
        PlayerSpawn();
    }

    void PlayerSpawn()
    {
        Vector3Int P1_Position = new Vector3Int(0, 12, 0);
        Vector3Int P2_Position = new Vector3Int(0, 0, 0);
        Vector3Int P3_Position = new Vector3Int(12, 0, 0);
        Vector3Int P4_Position = new Vector3Int(12, 12, 0);
        
        Vector3 P1_Spawn = tilemap.GetCellCenterWorld(P1_Position);
        Vector3 P2_Spawn = tilemap.GetCellCenterWorld(P2_Position);
        Vector3 P3_Spawn = tilemap.GetCellCenterWorld(P3_Position);
        Vector3 P4_Spawn = tilemap.GetCellCenterWorld(P4_Position);

        Instantiate(Player1, P1_Spawn, Quaternion.identity);
        Instantiate(Player2, P2_Spawn, Quaternion.identity);
        Instantiate(Player3, P3_Spawn, Quaternion.identity);
        Instantiate(Player4, P4_Spawn, Quaternion.identity);
    }
}