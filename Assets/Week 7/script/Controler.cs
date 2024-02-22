using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controler : MonoBehaviour
{
    public Slider chargeSlider;
    float chargeValue;
    public float maxcharge = 1;
    Vector2 direction;
    public static playerfootball Selectedplayer { get; private set; }
    public static void SetSelectedPlayer(playerfootball player) { 
    
    
        if(Selectedplayer != null)
        {
            Selectedplayer.Selected(false);
        }
        Selectedplayer = player;
        Selectedplayer.Selected(true);
    }
    private void FixedUpdate()
    {
        if(direction != Vector2.zero)
        {
            Selectedplayer.Move(direction);
            direction = Vector2.zero;
            chargeValue = 0;
            chargeSlider.value = chargeValue;
        }
    }
    private void Update()
    {
        if (Selectedplayer == null) return;

        if (Input.GetKeyDown(KeyCode.Space))//start at 0
        {
            chargeValue = 0;
            direction = Vector2.zero;
        }
        if (Input.GetKey(KeyCode.Space))//each flame biger and biger
        {
            chargeValue += Time.deltaTime;
            chargeValue = Mathf.Clamp(chargeValue, 0, maxcharge);//
            chargeSlider.value = chargeValue;
        }
        if (Input.GetKeyUp(KeyCode.Space))//push the engry on the player let it move
        {
            direction = ((Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition) - (Vector2)Selectedplayer.transform.position).normalized * chargeValue;
        }
    }


}
