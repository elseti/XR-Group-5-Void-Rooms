using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameMenuManager : MonoBehaviour
{
    public GameObject menu;
    public GameObject movement;
    public InputActionProperty showButton;
    public Transform head;
    public float spawnDistance = 1;
    // Start is called before the first frame update
    void Start()
    {
        
        movement.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        if(showButton.action.WasPressedThisFrame())
        {
            movement.SetActive(false);
            menu.SetActive(true);
            menu.transform.position = head.position + new Vector3(head.forward.x,0,head.forward.z).normalized * spawnDistance;
        
        }

        menu.transform.LookAt(new Vector3(head.position.x, menu.transform.position.y, head.position.z));
    }

    public void startGame()
    {
         movement.SetActive(true);
         menu.SetActive(false);    
    }
}
