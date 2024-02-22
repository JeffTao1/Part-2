using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerfootball : MonoBehaviour
{

    public Color colorn ;
    public Color colorr ;
    SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        Selected(false);
    }
    private void OnMouseDown()
    {
        Selected(true);
    }
    public void Selected(bool isSelected) 
    {

        if (isSelected ) 
        {


            spriteRenderer.color = colorr;
        
        
        }
        else 
        {

            spriteRenderer.color = colorn;
        }
        
            
        
        
    
    }
}
