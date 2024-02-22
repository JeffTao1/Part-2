using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.Experimental.GraphView;

public class playerfootball : MonoBehaviour
{

    public Color colorn ;
    public Color colorr ;
    SpriteRenderer spriteRenderer;
    public Rigidbody2D rb;
    public float speed;

    

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        Selected(false);

    }
    private void OnMouseDown()
    {
        Controler.SetSelectedPlayer(this);
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
    public void Move(Vector2 direction)
    {
        rb.AddForce(direction * speed);
    } 



}
