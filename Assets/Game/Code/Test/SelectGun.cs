using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectGun : MonoBehaviour
{
    private ActionGun ActionScript;
    public GameObject SelectArea;

    private PlayerHeart TestHeart;


    void Start() 
    {
        TestHeart = GameObject.FindFirstObjectByType<PlayerHeart>();

        ActionScript = GameObject.FindFirstObjectByType<ActionGun>();
    }


    private void OnMouseDown()
    {
        if (gameObject.CompareTag("SelectShoot"))
        {
            ActionScript.ShotGun -= 1;

            ActionScript.TShotGun();

            SelectArea.SetActive(false);

    
            TestHeart.DecreaseHeart(1);
        }
    }
}
