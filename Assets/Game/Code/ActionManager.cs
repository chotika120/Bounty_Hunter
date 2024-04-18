using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActionManager : MonoBehaviour
{
    public int ShotGun = 1;
    public int Shot = 5;


    public Image[] ShotGunImg;
    public Image[] ShotImg;
    public Sprite FullShot;
    public Sprite EmptyShot;


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


    public void SetPlayer(GameObject Player)
    {
        Code_PlayerManager = Player.GetComponent<PlayerManager>();
    }

    public void OnButtonClick()
    {
        if (Code_PlayerManager.CompareTag("Player1"))
        {
            Code_PlayerManager.AreaPosition_Boom();
            Debug.Log("P1");
        }
    }

}
