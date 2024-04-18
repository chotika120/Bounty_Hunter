using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class PlayerManager : MonoBehaviour
{
    public GameObject TileMove;
    public GameObject TileGun;
    public GameObject TileBoom;
    public GameManager Code_GameManager;

    public Vector3 P_Position;
    


    public void SetGameManager(GameManager gameSet) 
    {
        Code_GameManager = gameSet;
    }


    public void OnMouseDown()
    {

        if(gameObject.CompareTag("Player1") || gameObject.CompareTag("Player2") || gameObject.CompareTag("Player3") || gameObject.CompareTag("Player4"))
        {
            AreaPosition_Player();
            Debug.Log(gameObject.tag);
        };
        
    }


//Area Player
    public void AreaPosition_Player()
    {
        // TileMove Right
        if((int)P_Position.x != 12)
        {
            Instantiate(TileMove, Code_GameManager.tilemap.GetCellCenterWorld(new Vector3Int((int)P_Position.x + 1,(int)P_Position.y, 0)), Quaternion.identity);
        }


        // TileMove Left
        if((int)P_Position.x != 0)
        {
            Instantiate(TileMove, Code_GameManager.tilemap.GetCellCenterWorld(new Vector3Int((int)P_Position.x - 1,(int)P_Position.y, 0)), Quaternion.identity);
        }


        // TileMove Down
        if((int)P_Position.y != 0)
        {
            Instantiate(TileMove, Code_GameManager.tilemap.GetCellCenterWorld(new Vector3Int((int)P_Position.x, (int)P_Position.y - 1, 0)), Quaternion.identity);
        }


        // TileMove Up
        if((int)P_Position.y != 12)
        {
            Instantiate(TileMove, Code_GameManager.tilemap.GetCellCenterWorld(new Vector3Int((int)P_Position.x, (int)P_Position.y + 1, 0)), Quaternion.identity);   
        }

    }


    public void AreaPosition_Gun()
    {
        // TileGun Right
        for (int i = (int)P_Position.x + 1; i <= 12; i++)
        {
            Instantiate(TileGun, Code_GameManager.tilemap.GetCellCenterWorld(new Vector3Int(i,(int)P_Position.y, 0)), Quaternion.identity);
        }


        // TileGun Left
        for (int i = (int)P_Position.x - 1; i >= 0; i--)
        {
            if(Code_GameManager == null)
            {
                Debug.Log(" Oh nooo");
            }
            Instantiate(TileGun, Code_GameManager.tilemap.GetCellCenterWorld(new Vector3Int(i,(int)P_Position.y, 0)), Quaternion.identity);
        }


        // TileMove Down
        for (int i = (int)P_Position.y - 1; i >= 0; i--)
        {
            Instantiate(TileGun, Code_GameManager.tilemap.GetCellCenterWorld(new Vector3Int((int)P_Position.x, i, 0)), Quaternion.identity);
        }


        // TileMove Up
        for (int i = (int)P_Position.y + 1; i <= 12; i++)
        {
            Instantiate(TileGun, Code_GameManager.tilemap.GetCellCenterWorld(new Vector3Int((int)P_Position.x, i, 0)), Quaternion.identity);
        }
    }


    public void AreaPosition_Boom()
    {
        for (int i = 1; i <= 3; i++)
        {

            // TileBoom Up
            if((int)P_Position.y + i <= 12)
            {
                Instantiate(TileBoom, Code_GameManager.tilemap.GetCellCenterWorld(new Vector3Int((int)P_Position.x,(int)P_Position.y + i, 0)), Quaternion.identity);
            }

            // TileBoom Down
            if((int)P_Position.y - i >= 0)
            {
                Instantiate(TileBoom, Code_GameManager.tilemap.GetCellCenterWorld(new Vector3Int((int)P_Position.x,(int)P_Position.y - i, 0)), Quaternion.identity);
            }

            ///////////

            for (int n = 0; n <= 3; n++)
            {

            // TileBoom Right(Up)
            if((int)P_Position.x + i <= 12 && (int)P_Position.y + n <= 12)
            {
                Instantiate(TileBoom, Code_GameManager.tilemap.GetCellCenterWorld(new Vector3Int((int)P_Position.x + i,(int)P_Position.y + n, 0)), Quaternion.identity);
            }

            

            // TileBoom Left(Down)
            if((int)P_Position.x - i >= 0 && (int)P_Position.y + n <= 12)
            {
                Instantiate(TileBoom, Code_GameManager.tilemap.GetCellCenterWorld(new Vector3Int((int)P_Position.x - i,(int)P_Position.y + n, 0)), Quaternion.identity);
            }

            }

            ///////////

            for (int n = 1; n <= 3; n++)
            {

            // TileBoom Right(Down)
            if((int)P_Position.x + i <= 12 && (int)P_Position.y - n >= 0)
            {
                Instantiate(TileBoom, Code_GameManager.tilemap.GetCellCenterWorld(new Vector3Int((int)P_Position.x + i,(int)P_Position.y - n, 0)), Quaternion.identity);
            }

            

            // TileBoom Left(Up)
            if((int)P_Position.x - i >= 0 && (int)P_Position.y - n >= 0)
            {
                Instantiate(TileBoom, Code_GameManager.tilemap.GetCellCenterWorld(new Vector3Int((int)P_Position.x - i,(int)P_Position.y - n, 0)), Quaternion.identity);
            }

            }

        }


    }

}
