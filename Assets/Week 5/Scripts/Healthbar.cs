using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour
{
    public Slider slider;



    public void TakeDamge(float Damge) 
    {
        slider.value -= Damge;

    }
    public void healcheck(float Heal) 
    {
        slider.value = Heal;
    }


}
