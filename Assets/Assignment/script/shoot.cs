using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class shoot : MonoBehaviour
{

    public float howlong;
    public GameObject go;
    public Transform place;
    public GameObject player;
    public float speed;
    float onlyx;

    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {

        if (player != null)
        {

           
            transform.position = Vector2.MoveTowards(transform.position,player.transform.position, speed * Time.deltaTime);

        }
        if (howlong > 5)//every five scd 
        {
            GameObject weapon = Instantiate(go, place.position, place.rotation);// make/bron the weapon 
            howlong = 0;

        }
        howlong = howlong + Time.deltaTime; //make the howlong math by scd


    }
}
