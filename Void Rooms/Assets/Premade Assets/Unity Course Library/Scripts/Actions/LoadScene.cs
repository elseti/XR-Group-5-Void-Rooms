using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Load scene using name, or reload the active scene
/// </summary>

public class LoadScene : MonoBehaviour
{

    GameMenuManager menuManager;

    void Start()
    {
        menuManager = GameObject.FindGameObjectWithTag("GameMenuController").GetComponent<GameMenuManager>();

    }


    public void LoadSceneUsingName(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void ReloadCurrentScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void StartGame()
    {
        menuManager.startGame();
    }

}
