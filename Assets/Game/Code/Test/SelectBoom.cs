using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectBoom : MonoBehaviour
{
    
    private ActionBoom ActionScript;
    public GameObject ItemBoom;
    public GameObject SelectArea;

    private PlayerHeart TestHeart;

    void Start() 
    {

        TestHeart = GameObject.FindFirstObjectByType<PlayerHeart>();

        ActionScript = GameObject.FindFirstObjectByType<ActionBoom>();
        ItemBoom.SetActive(false);
    }


    private void OnMouseDown()
    {
        if (gameObject.CompareTag("SelectBoom"))
        {
            ActionScript.Boom -= 1;

            ActionScript.TBoom();

            ItemBoom.SetActive(true);
            SelectArea.SetActive(false);

            TestHeart.DecreaseHeart(2);
        }
    }
    
}
