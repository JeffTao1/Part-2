using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.Collections.AllocatorManager;

public class Weapon : MonoBehaviour
{
    Rigidbody2D rb;
    Vector2 speed = new Vector2(-4,0);
    float nothitdestory = 5f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

            Destroy(gameObject,nothitdestory);

    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        collision.SendMessage("TakeDamge", 1);
        Destroy(gameObject);


    }

}
