using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    
    public GameObject Player;

    void Start() {
        Instantiate(Player, new Vector3(-6,-6),Quaternion.identity);
    }
}
