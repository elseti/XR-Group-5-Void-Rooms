using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class SceneTransitionManager : MonoBehaviour
{
    public FadeScreen fadeScreen;
    public GameObject gameManager;

    private bool fadeStarted = false;

    public void GoToScene(string sceneName)
    {
        if (!fadeStarted)
        {
        StartCoroutine(GoToSceneRoutine(sceneName));
        }
    }

    IEnumerator GoToSceneRoutine(string sceneName)
    {   
        fadeStarted = true;
        fadeScreen.FadeOut();
        yield return new WaitForSeconds(fadeScreen.fadeDuration);
        SceneManager.LoadScene(sceneName);
        Destroy(gameManager);

   }


}
