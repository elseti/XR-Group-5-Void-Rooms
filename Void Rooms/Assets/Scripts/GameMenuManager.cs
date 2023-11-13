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
    public float spawnDistance = 2;
    public bool pause = true;
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
            menu.SetActive(!menu.activeSelf);

            menu.transform.position = head.position + new Vector3(head.forward.x,0,head.forward.z).normalized * spawnDistance;

            pause = !pause;


            if(pause)
            {
                movement.SetActive(false);

            }
            else
            {
                movement.SetActive(true);

            }

            

        }

        menu.transform.LookAt(new Vector3(head.position.x, menu.transform.position.y, head.position.z));
    }
}
