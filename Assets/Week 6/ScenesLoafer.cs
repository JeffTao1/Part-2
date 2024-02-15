using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesLoafer : MonoBehaviour
{
    public void loadnextscene() {

        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextScenceIndex = (currentSceneIndex + 1) % SceneManager.sceneCountInBuildSettings;
        SceneManager.LoadScene(nextScenceIndex);
    }
}
