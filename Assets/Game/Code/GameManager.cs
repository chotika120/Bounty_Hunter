using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class GameManager : MonoBehaviour
{
    public GameObject Player1;
    public GameObject Player2;
    public GameObject Player3;
    public GameObject Player4;

    public Tilemap tilemap;

    public ActionManager Code_ActionManager;

    void Start()
    {
        PlayerSpawn();
        Code_ActionManager.SetPlayer(Player1);

        Player1.GetComponent<PlayerManager>().SetGaManager(this);
    }

    public void PlayerSpawn()
    {

        //Test 01
        Player1.GetComponent<PlayerManager>().P_Position= new Vector3Int(9, 6, 0);
        Vector3 P1_Position = tilemap.GetCellCenterWorld(new Vector3Int(9, 6, 0));
        Instantiate(Player1, P1_Position, Quaternion.identity);


        // Player1.GetComponent<PlayerManager>().P_Position= new Vector3Int(0, 12, 0);
        // Vector3 P1_Position = tilemap.GetCellCenterWorld(new Vector3Int(0, 12, 0));
        // Instantiate(Player1, P1_Position, Quaternion.identity);
        

        Player2.GetComponent<PlayerManager>().P_Position= new Vector3Int(0, 0, 0);
        Vector3 P2_Position = tilemap.GetCellCenterWorld(new Vector3Int(0, 0, 0));
        Instantiate(Player2, P2_Position, Quaternion.identity);


        Player3.GetComponent<PlayerManager>().P_Position= new Vector3Int(12, 0, 0);
        Vector3 P3_Position = tilemap.GetCellCenterWorld(new Vector3Int(12, 0, 0));
        Instantiate(Player3, P3_Position, Quaternion.identity);


        Player4.GetComponent<PlayerManager>().P_Position= new Vector3Int(12, 12, 0);
        Vector3 P4_Position = tilemap.GetCellCenterWorld(new Vector3Int(12, 12, 0));
        Instantiate(Player4, P4_Position, Quaternion.identity);

    }
    
}
