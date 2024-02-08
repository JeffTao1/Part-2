using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knight : MonoBehaviour
{
    Vector2 destination;
    Vector2 movement;
    public float speed = 4;
    Rigidbody2D rb;
    Animator animator;
    bool click = false;
    int health;
    public int maxhealth = 5;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();   
        animator = GetComponent<Animator>();
        health = maxhealth;
    }

    private void FixedUpdate()
    {
        movement = destination - (Vector2)transform.position;
        if (movement.magnitude < 0.1) 
        { 
            movement = Vector2.zero;
        
        }
        rb.MovePosition(rb.position + movement.normalized * speed * Time.deltaTime); 
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !click)
        {

            destination = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        }
        animator.SetFloat("Movement", movement.magnitude);

        
    }
    private void OnMouseDown()
    {
        click = true;
        takeDamge(1);
    }
    private void OnMouseUp()
    {
        click = false;
    }
    void takeDamge(int damge)
    {
        health -= damge;
        health = Mathf.Clamp(health, 0, maxhealth);
        if(health == 0)
        {
            animator.SetTrigger("Death");
        }
        else
        {
            animator.SetTrigger("TakeDamage");
        }

    }
}
