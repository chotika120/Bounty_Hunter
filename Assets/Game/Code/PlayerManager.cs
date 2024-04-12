using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class PlayerManager : MonoBehaviour
{
    public GameObject TileMove;
    
    private GameManager Code_GameManager;

    public Vector3 Player_Position;



    void Start() 
    {
        Code_GameManager = GameObject.FindFirstObjectByType<GameManager>();
    }


    private void OnMouseDown()
    {

        if (gameObject.CompareTag("Player"))
        {
            {
                AreaPosition_P1();
                Debug.Log("P1");
            }
        }
    }


    void AreaPosition_P1()
    {
        Instantiate(TileMove, Code_GameManager.tilemap.GetCellCenterWorld(new Vector3Int((int)Player_Position.x + 1,(int)Player_Position.y, 0)), Quaternion.identity);
        Instantiate(TileMove, Code_GameManager.tilemap.GetCellCenterWorld(new Vector3Int((int)Player_Position.x - 1,(int)Player_Position.y, 0)), Quaternion.identity);
        Instantiate(TileMove, Code_GameManager.tilemap.GetCellCenterWorld(new Vector3Int((int)Player_Position.x, (int)Player_Position.y - 1, 0)), Quaternion.identity);
        Instantiate(TileMove, Code_GameManager.tilemap.GetCellCenterWorld(new Vector3Int((int)Player_Position.x, (int)Player_Position.y + 1, 0)), Quaternion.identity);
    }
}
