using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerHeart : MonoBehaviour
{
    public int Heart = 3;
    public TMP_Text HeartPlayer;
    public GameObject Die;

    void Start()
    {
        HeartPlayer.text = Heart.ToString();
    }

    public void DecreaseHeart(int amount)
    {
        Heart -= amount;
        Heart = Mathf.Max(Heart,0);
        HeartPlayer.text = Heart.ToString();

        if (Heart <= 0)
        {
            Die.SetActive(true);
        } 
    }

}
