using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class PlayerManager : MonoBehaviour
{
    public GameObject TileMove;
    private GameManager Code_GameManager;
    public Vector3 P_Position;


    void Start() 
    {
        Code_GameManager = GameObject.FindFirstObjectByType<GameManager>();
    }


    public void OnMouseDown()
    {

        if(gameObject.CompareTag("Player1") || gameObject.CompareTag("Player2") || gameObject.CompareTag("Player3") || gameObject.CompareTag("Player4"))
        {
            AreaPosition_Player();
            Debug.Log(gameObject.tag);
        }
        
    }


    void AreaPosition_Player()
    {
        // TileMove Right
        if((int)P_Position.x != 12)
        {
            Instantiate(TileMove, Code_GameManager.tilemap.GetCellCenterWorld(new Vector3Int((int)P_Position.x + 1,(int)P_Position.y, 0)), Quaternion.identity);
        };


        // TileMove Left
        if((int)P_Position.x != 0)
        {
            Instantiate(TileMove, Code_GameManager.tilemap.GetCellCenterWorld(new Vector3Int((int)P_Position.x - 1,(int)P_Position.y, 0)), Quaternion.identity);
        };


        // TileMove Down
        if((int)P_Position.y != 0)
        {
            Instantiate(TileMove, Code_GameManager.tilemap.GetCellCenterWorld(new Vector3Int((int)P_Position.x, (int)P_Position.y - 1, 0)), Quaternion.identity);
        };


        // TileMove Up
        if((int)P_Position.y != 12)
        {
            Instantiate(TileMove, Code_GameManager.tilemap.GetCellCenterWorld(new Vector3Int((int)P_Position.x, (int)P_Position.y + 1, 0)), Quaternion.identity);   
        };

    }

}
