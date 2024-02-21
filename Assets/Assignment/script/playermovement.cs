using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.Collections.AllocatorManager;

public class playermovement : MonoBehaviour
{




    public AnimationCurve landing;
    Rigidbody2D rb;

    float time = 0;


    private void Start()
    {
 

 

        rb = GetComponent<Rigidbody2D>();







    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            time += 0.5F * Time.deltaTime;
            float interpolation = landing.Evaluate(time);
            Vector3 something =  Vector3.Lerp(Vector3.one, Vector3.zero, interpolation);
            transform.position = new Vector3 (0,-something.y,0);
        }
    }
  

     
 





}
