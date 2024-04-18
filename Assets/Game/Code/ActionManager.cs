using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActionManager : MonoBehaviour
{
    // UI Action Gun
    public int ShotGun = 1;
    public int Shot = 5;
    public Image[] ShotGunImg;
    public Image[] ShotImg;
    public Sprite FullShot;
    public Sprite EmptyShot;


    // UI Action Boom
    public int Boom = 1;
    public Image[] BoomImg;
    public Sprite FullBoom;
    public Sprite EmptyBoom;


    private PlayerManager Code_PlayerManager;


    public void Action_ShotGun()
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


    public void Action_Shot()
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


    public void Action_Boom()
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




    public void SetPlayer(GameObject Player)
    {
        Code_PlayerManager = Player.GetComponent<PlayerManager>();
    }

    public void AreaGun()
    {
        if (Code_PlayerManager.CompareTag("Player1") || Code_PlayerManager.CompareTag("Player2") || Code_PlayerManager.CompareTag("Player3") || Code_PlayerManager.CompareTag("Player4"))
        {
            if(ShotGun == 1)
            {
                Code_PlayerManager.AreaPosition_Gun();
                Debug.Log(gameObject.tag);
            }
        }
    }


    public void AreaBoom()
    {
        if (Code_PlayerManager.CompareTag("Player1") || Code_PlayerManager.CompareTag("Player2") || Code_PlayerManager.CompareTag("Player3") || Code_PlayerManager.CompareTag("Player4"))
        {
            if(Boom == 1)
            {
                Code_PlayerManager.AreaPosition_Boom();
                Debug.Log(gameObject.tag);
            }
        }
    }

}
