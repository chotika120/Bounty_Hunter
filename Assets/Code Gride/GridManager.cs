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
      Test();
    }



    void GenerateGride() {
        for (int x = 0; x < width; x++){
            for (int y = 0; y < height; y++){
                var spawnedTile = Instantiate(TilePrefab,new Vector3(x, y), Quaternion.identity);
                spawnedTile.name = $"Tile {x} {y}";

            }
        }

        cam.transform.position = new Vector3((float)width/2 -0.5f, (float)height/2 -0.5f,-10);

    }


   void Test() {

        Instantiate(WallPrefab, new Vector3(6, 12), Quaternion.identity);
        Instantiate(WallPrefab, new Vector3(2, 11), Quaternion.identity);
        Instantiate(WallPrefab, new Vector3(10, 10), Quaternion.identity);
        Instantiate(WallPrefab, new Vector3(4, 9), Quaternion.identity);
        Instantiate(WallPrefab, new Vector3(3, 8), Quaternion.identity);
        Instantiate(WallPrefab, new Vector3(8, 9), Quaternion.identity);
        Instantiate(WallPrefab, new Vector3(9, 8), Quaternion.identity);

   }
    
    


}