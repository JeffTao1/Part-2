using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Starting : MonoBehaviour
{
    public float speed;


    public void Update()
    {
        transform.Translate(-speed * Time.deltaTime, 0, 0);
    }
}
