using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class SceneTransitionManager : MonoBehaviour
{
    public FadeScreen fadeScreen;

    public void GoToScene(int sceneIndex)
    {
    StartCoroutine(GoToSceneRoutine(sceneIndex));
    }

    IEnumerator GoToSceneRoutine(int sceneIndex)
    {
    fadeScreen.FadeOut();
    yield return new WaitForSeconds(fadeScreen.fadeDuration);
 
    SceneManager.LoadScene(sceneIndex);

   }

    // Update is called once per frame
    void Update()
    {
        
    }
}