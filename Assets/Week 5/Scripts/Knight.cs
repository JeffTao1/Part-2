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
    public int health;
    public int maxhealth = 5;
    bool isdied = false;
    public Healthbar healthbar;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();   
        animator = GetComponent<Animator>();
        health = maxhealth;
    }

    private void FixedUpdate()
    {
        if (isdied) return;
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
        if (isdied) return;
        if (Input.GetMouseButtonDown(0) && !click)
        {

            destination = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        }
        animator.SetFloat("Movement", movement.magnitude);
        if(Input.GetMouseButtonDown(1) )
        {
            animator.SetTrigger("attack");
        }

        
    }
    private void OnMouseDown()
    {
        if (isdied) return;
        click = true;

        SendMessage("TakeDamge", 1);
    }
    private void OnMouseUp()
    {
        click = false;
    }
    public void TakeDamge(int damge)
    {
        health -= damge;
        health = Mathf.Clamp(health, 0, maxhealth);
        if(health == 0)
        {
            isdied = true;
            animator.SetTrigger("Death");
        }
        else
        {
            isdied= false;
            animator.SetTrigger("TakeDamage");
        }

    }
}
