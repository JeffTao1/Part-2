using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startshot : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextScenceIndex = (currentSceneIndex + 1) % SceneManager.sceneCountInBuildSettings;// base on the scene now and plus one scene to the play scene
        SceneManager.LoadScene(nextScenceIndex);
        Destroy(gameObject);
    }
    
}
