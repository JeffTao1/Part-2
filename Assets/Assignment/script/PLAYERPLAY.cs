
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PLAYERPLAY : MonoBehaviour { 
    Vector2 destination;
    Vector2 movement;
    public float speed = 4;
    Rigidbody2D rb;
    Animator animator;//use this then can use animtion in the script
  


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

       
       
    }
    private void FixedUpdate()
    {
        
        movement = destination - (Vector2)transform.position; // where the player go
        if (movement.magnitude < 0.1) // to make sure the move is not make the game object shaking "move not what we want"
        {
            movement = Vector2.zero;

        }
        rb.MovePosition(rb.position + movement.normalized * speed * Time.deltaTime); // move the player and  tim.deltaTime is fix the flame move
    }


    void Update()
    {
      
        if (Input.GetMouseButtonDown(0) ) // use left mouse
        {

            destination = Camera.main.ScreenToWorldPoint(Input.mousePosition);// use the mouse to move and the camera point is the mouse position then where I point where i go

        }
        animator.SetTrigger("Player");// run the player animation
        SendMessage("dmg");
        
       


    }
    private void OnTriggerEnter2D(Collider2D collision)//when it tunch on a trigger Object it will Destroy
    {
        Destroy(gameObject);
    }






}





