using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
   [SerializeField] private int width , height;

   [SerializeField] private Tile TilePrefab;

   [SerializeField] public Wall WallPrefab;

   [SerializeField] private Transform cam;


    void Start(){
      GenerateGride();
    }



    void GenerateGride() {
        for (int x = 0; x < width; x++){
            for (int y = 0; y < height; y++){

              //  var spawnedTile = Instantiate(TilePrefab,new Vector3(x, y), Quaternion.identity);
              //  spawnedTile.name = $"Tile {x} {y}";

                if ((x == 6 && y == 12) || (x == 2 && y == 11) || (x == 11 && y == 10) || (x == 4 && y == 9) 
                || (x == 8 && y == 9) || (x == 3 && y == 8) || (x == 9 && y == 8) || (x == 0 && y == 6) || (x == 12 && y == 6) 
                || (x == 3 && y == 4) || (x == 9 && y == 4) || (x == 4 && y == 3) || (x == 8 && y == 3) || (x == 1 && y == 2) 
                || (x == 10 && y == 1) || (x == 6 && y == 0))

                 { // เพิ่มเงื่อนไขสำหรับตำแหน่ง Wall เพิ่มเติม
                    var spawnedTile = Instantiate(TilePrefab, new Vector3(x, y), Quaternion.identity);
                    spawnedTile.name = $"Tile {x} {y}";

                    var spawnedWall = Instantiate(WallPrefab, new Vector3(x, y), Quaternion.identity);
                    spawnedWall.name = $"Wall {x} {y}";

                } else {
                    var spawnedTile = Instantiate(TilePrefab, new Vector3(x, y), Quaternion.identity);
                    spawnedTile.name = $"Tile {x} {y}";
                }
            }
        }

       cam.transform.position = new Vector3((float)width/2 - 0.5f, (float)height/2 - 0.5f, -10);
    }



}