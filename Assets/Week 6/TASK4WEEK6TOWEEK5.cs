using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TASK4WEEK6TOWEEK5 : MonoBehaviour
{
    public void loadnextscene()
    {

        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextScenceIndex = (currentSceneIndex -1) % SceneManager.sceneCountInBuildSettings;
        SceneManager.LoadScene(nextScenceIndex);
    }
    public void sixteen9() 
    {

        Screen.SetResolution(1920, 1080, false);
    
    
    }

    public void FULLHD()
    {

        Screen.SetResolution(1920, 1080, true);


    }
}
