using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject Controller;
    public GameObject MovePlate;


    //เดี๋ยวมาแก้ตำแหน่ง

    private int xMax = -1; 
    private int yMax = -1;

    private string Player;

    public Sprite Player1;
    public Sprite Player2;
    public Sprite Player3;
    public Sprite Player4;

    public void Activate()
    {
        Controller = GameObject.FindGameObjectWiththTag("GameController");
        
        SetSpawn();

        switch(this.name)
        {
            case "Player1": this.GetComponent<SpriteRenderer>().Sprite = Player1; break;
            case "Player2": this.GetComponent<SpriteRenderer>().Sprite = Player2; break;
            case "Player3": this.GetComponent<SpriteRenderer>().Sprite = Player3; break;
            case "Player4": this.GetComponent<SpriteRenderer>().Sprite = Player4; break;
        }

    }

    //เดี๋ยวมาแก้ จุด Spawn

    public void SetSpawn(){
        float x = xMax;
        float y = xMax;

        x *= 0.66f;
        y *= 0.66f;


        x += -2.3f;
        y += -2.3f;


        this.transform.position = new Vector3(x,y,-1.0f);


    }

}
