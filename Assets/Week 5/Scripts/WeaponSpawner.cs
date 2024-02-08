using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponSpawner : MonoBehaviour
{

    public GameObject go;


    // Start is called before the first frame update
    void Start()
    {

    }
    

    // Update is called once per frame
    public void weapon()
    {


            Instantiate(go, transform.position, transform.rotation);

    }
}
