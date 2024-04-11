using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class CheckTile : MonoBehaviour
{
    public Tilemap tile;

    public Vector3Int location;
    

    void Update()
    {

        if(Input.GetMouseButtonDown(1)){
            GetT();
        }
        
    }

    void GetT()
    {
        Vector3 mp = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        location = tile.WorldToCell(mp);

        if(tile.GetTile(location))
        {
            Debug.Log("Tile" + location);
        }
        else
        {
            Debug.Log("No Tile" + location);
        }

    }

    
}
