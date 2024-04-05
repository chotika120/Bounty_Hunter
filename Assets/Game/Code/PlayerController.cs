using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    public GameObject TileWalk;

    void Start()
    {
        PlayerWalk();
    }

    void PlayerWalk()
    {

        if (Input.GetMouseButtonDown(0))
        {
            if (gameObject.CompareTag("Player"))
            {
                TileWalk.SetActive(true);
            }
            else
            {
                TileWalk.SetActive(false);
            }
        }
    }


    void SelectWalk()
    {
        Instantiate(TileWalk, new Vector3(6, 6, 0), Quaternion.identity);
    }

}
