using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectWalk : MonoBehaviour
{
    private ActionGun ActionScript;
    public GameObject SelectArea;

    void Start() 
    {
        ActionScript = GameObject.FindFirstObjectByType<ActionGun>();
    }


    private void OnMouseDown()
    {
        if (gameObject.CompareTag("SelectWalk"))
        {
            SelectArea.SetActive(false);

            if( ActionScript.ShotGun == 0 && ActionScript.Shot > 0) 
            {
                ActionScript.ShotGun += 1;
                ActionScript.Shot -= 1;

            }

        }
    }



}
