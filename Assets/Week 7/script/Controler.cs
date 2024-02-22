using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controler : MonoBehaviour
{
    public static playerfootball Selectedplayer { get; private set; }
    public static void SetSelectedPlayer(playerfootball player) { 
    
    
        if(Selectedplayer != null)
        {
            Selectedplayer.Selected(false);
        }
        Selectedplayer = player;
        Selectedplayer.Selected(true);
    }
}
