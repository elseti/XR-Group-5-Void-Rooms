using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameMenuManager : MonoBehaviour
{
    public GameObject menu;
    public GameObject startMenu;
    public GameObject movement;
    public InputActionProperty showButton;
    public Transform head;
    public float spawnDistance = 3;
    private bool paused = false;
    private bool gameStarted = false;

    // Start is called before the first frame update
    void Start()
    {
        movement.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if(showButton.action.WasPressedThisFrame() && gameStarted) 
        {
            movement.SetActive(paused);
            menu.SetActive(!paused);
            menu.transform.position = head.position + new Vector3(head.forward.x,0,head.forward.z).normalized * spawnDistance;
            paused = !paused;
        
        }

        menu.transform.LookAt(new Vector3(head.position.x, menu.transform.position.y, head.position.z));
    }

    public void startGame()
    {
        startMenu.SetActive(false);
        movement.SetActive(true);
        gameStarted = true;
    }
}
