using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rUNWWAY : MonoBehaviour
{
    public Collider2D collision;
    public int mark;

    private void OnTriggerStay2D(Collider2D collision)
    {

        if (this.collision.OverlapPoint(collision.transform.position)) {


            Destroy(collision.gameObject);

            mark++;
            Debug.Log(mark);
            


        }


        }


            
        
       





}
