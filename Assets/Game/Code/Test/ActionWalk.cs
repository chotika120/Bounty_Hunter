using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionWalk : MonoBehaviour
{
    public GameObject PlayerWalk;
    private SelectWalk ActionScript;

    private ActionBoom BoomScript;
    private ActionGun GunScript;


    void Start() 
    {
       ActionScript = GameObject.FindFirstObjectByType<SelectWalk>();
       BoomScript = GameObject.FindFirstObjectByType<ActionBoom>();
       GunScript = GameObject.FindFirstObjectByType<ActionGun>();
       ActionScript.SelectArea.SetActive(false);
    }


    private void OnMouseDown()
    {
        if (gameObject.CompareTag("Player"))
        {
            ActionScript.SelectArea.SetActive(true);
            GunScript.AreaGun.SetActive(false);

            if(BoomScript.Boom == 1)
            {
                BoomScript.AreaBoom.SetActive(false);
            }

        }
    }
}
