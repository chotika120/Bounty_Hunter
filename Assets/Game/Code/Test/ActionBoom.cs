using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActionBoom : MonoBehaviour
{
    public int Boom = 1;

    public Image[] BoomImg;
    public Sprite FullBoom;
    public Sprite EmptyBoom;

    public GameObject AreaBoom;
    private ActionGun ActionScript;
    private SelectWalk WalkScript;

    void Start() 
    {
        AreaBoom.SetActive(false);
        ActionScript = GameObject.FindFirstObjectByType<ActionGun>();
        WalkScript = GameObject.FindFirstObjectByType<SelectWalk>();
    }

    public void TBoom()
    {
        foreach (Image img in BoomImg)
        { 
            img.sprite = EmptyBoom;
        }
        for (int i = 0; i < Boom; i++)
        {
            BoomImg[i].sprite = FullBoom;
        }


        if(Boom < 1)
        {
            Debug.Log("Boom = 0");
        }
    }

    public void BoomArea()
    {
        if(Boom == 1)
        {
            AreaBoom.SetActive(true);
            ActionScript.AreaGun.SetActive(false);
            WalkScript.SelectArea.SetActive(false);
        }
    }

}
