using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickHandler : MonoBehaviour {

    public GameObject transaparentshirt; 
    public Sprite firstSprite; 
    private SpriteRenderer spriterender;
  
    void Start()
    {
        spriterender = transaparentshirt.GetComponent<SpriteRenderer>();

    }
  
    void OnMouseDown()
    {
        spriterender.sprite = firstSprite;
       
       

    }

}
