using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Test : MonoBehaviour
{
    public GameObject TMove;
    
    private Player P_Move;



    void Start() 
    {
       P_Move = GameObject.FindFirstObjectByType<Player>();
    }


    private void OnMouseDown()
    {
        if (gameObject.CompareTag("Player"))
        {
            TMove_Test();
        }
    }


    void TMove_Test()
    {
        Vector3Int P_Position = P_Move.tilemap.WorldToCell(P_Move.transform.position);

        Instantiate(TMove, P_Move.tilemap.GetCellCenterWorld(P_Position + new Vector3Int(0, 1, 0)), Quaternion.identity);
        Instantiate(TMove, P_Move.tilemap.GetCellCenterWorld(P_Position + new Vector3Int(-1, 0, 0)), Quaternion.identity);
        Instantiate(TMove, P_Move.tilemap.GetCellCenterWorld(P_Position + new Vector3Int(0, -1, 0)), Quaternion.identity);
        Instantiate(TMove, P_Move.tilemap.GetCellCenterWorld(P_Position + new Vector3Int(1, 0, 0)), Quaternion.identity);
    }
}
