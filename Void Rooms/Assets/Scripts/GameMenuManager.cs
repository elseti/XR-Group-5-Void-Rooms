using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameMenuManager : MonoBehaviour
{
    public GameObject menu;
    public GameObject startMenu;
    public GameObject finalMenu;
    public GameObject transitionMenu;
    public GameObject movement;
    public InputActionProperty showButton;
    public Transform head;
    public float spawnDistance = 3;
    private bool isPaused = false;
    private bool isStarted = false;

    // Start is called before the first frame update
    void Start()
    {
        
        //movement.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        if(showButton.action.WasPressedThisFrame() && isStarted)
        {
            movement.SetActive(isPaused);
            menu.SetActive(!isPaused);
            menu.transform.position = head.position + new Vector3(head.forward.x,0,head.forward.z).normalized * spawnDistance;
            isPaused = !isPaused;
        }

        menu.transform.LookAt(new Vector3(head.position.x, menu.transform.position.y, head.position.z));
    }

    public void startGame()
    {
         movement.SetActive(true);
         startMenu.SetActive(false);    
         isStarted = true;
    }

    public void selectedCorrect()
    {
        finalMenu.SetActive(true);
    }

    public void preTransition()
    {
        finalMenu.SetActive(false);
        transitionMenu.SetActive(true);
    }
}
