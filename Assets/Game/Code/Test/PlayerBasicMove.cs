using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBasicMove : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
            transform.Translate(0, 1f, 0);
        if (Input.GetKeyDown(KeyCode.S))
            transform.Translate(0, -1f, 0);
        if (Input.GetKeyDown(KeyCode.A))
            transform.Translate(-1f, 0 , 0);
        if (Input.GetKeyDown(KeyCode.D))
            transform.Translate(1f, 0, 0);
    }
}