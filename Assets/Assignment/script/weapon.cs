using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour
{

    public float speed = 2;
    Rigidbody2D rb;


    public Transform WHERE;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();// to use Rigidbody2d
    }

    // Update is called once per frame
    void Update()
    {

         transform.Translate(0, 1 * speed * Time.deltaTime, 0);// make the weapon move and where(side) it will move too



    }



    private void OnTriggerEnter2D(Collider2D collision)// make the object Destroy when tunch on the isTrigger object
    {
        Destroy(gameObject);

    }
    public void dmg() // I need a sendMessege
    {
        Debug.Log("Hi man");
    
    }
}
