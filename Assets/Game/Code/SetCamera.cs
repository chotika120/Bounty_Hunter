using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetCamera : MonoBehaviour
{
    private float startX = 6.5f;
    private float startY = 6.5f;

    void Start()
    {
        transform.position = new Vector3(startX, startY, transform.position.z);
    }
}
