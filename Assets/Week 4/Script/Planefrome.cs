using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planefrome : MonoBehaviour
{
    public int timerspawns;
    public float time;
    public GameObject go;



    // Start is called before the first frame update
    void Start()
    {
   

             
        Instantiate(go, new Vector3(Random.Range(-5, 5), Random.Range(-5, 5), 0), Quaternion.Euler(0, 0, Random.Range(0, 360)));
 
    }

    // Update is called once per frame
    void Update()
    {

        time = time + Time.deltaTime;
        if (time >5) 
        {

           GameObject newPlane =  Instantiate(go, new Vector3(Random.Range(-5, 5), Random.Range(-5, 5), 0),  Quaternion.Euler(0,0,Random.Range(0,360)));
            time = 0;

        }
        
       
    }
}
