//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class MapGenerate : MonoBehaviour
{
    public Texture2D map;

    public ColorPrefab[] colorMap;

    void Start()
    {
        GenerateMap();
    }

    void GenerateMap()
    {
        for (int x = 0; x < map.width; x++)
        {
            for (int y = 0; y < map.height; y++)
            {
                GenerateTile(x,y);
            }
        }
    }

    void GenerateTile(int x, int y)
    {
        Color pixelColor = map.GetPixel(x,y);

        if (pixelColor.a == 0)
        {
            return;
        }

      /*  foreach (ColorPrefab colorMap in colorMap)
        {
            if (colorMap.color.Equals(pixelColor))
            {
                Vector2 position = new Vector2(x, y);
                Instantiate(colorMap.prefab, position, Quaternion.identity , transform);
            }
        }*/
    }

}
