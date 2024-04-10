using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActionGun : MonoBehaviour
{

    public int ShotGun = 1;
    public int Shot = 5;


    public Image[] ShotGunImg;
    public Image[] ShotImg;
    public Sprite FullShot;
    public Sprite EmptyShot;


    public GameObject AreaGun;
    private ActionBoom ActionScript;
    private SelectWalk WalkScript;

    void Start() 
    {
        AreaGun.SetActive(false);
        ActionScript = GameObject.FindFirstObjectByType<ActionBoom>();
        WalkScript = GameObject.FindFirstObjectByType<SelectWalk>();
    }


    void Update()
    {
        TShotGun();
        TShot();
    }


    public void TShotGun()
    {
        foreach (Image img in ShotGunImg)
        { 
            img.sprite = EmptyShot;
        }
        for (int i = 0; i < ShotGun; i++)
        {
            ShotGunImg[i].sprite = FullShot;
        }


        if(ShotGun < 1)
        {
            Debug.Log("ShotGun = 0");
        }
    }


    public void TShot()
    {
        foreach (Image img in ShotImg)
        { 
            img.sprite = EmptyShot;
        }
        for (int i = 0; i < Shot; i++)
        {
            ShotImg[i].sprite = FullShot;
        }


        if(Shot < 1)
        {
            Debug.Log("Shot = 0");
        }
    }


    public void GunArea()
    {
        
        if(ShotGun == 1)
        {
            AreaGun.SetActive(true);
            WalkScript.SelectArea.SetActive(false);

            if(ActionScript.Boom == 1)
            {
                ActionScript.AreaBoom.SetActive(false);
            }
        }
        
    }
}
