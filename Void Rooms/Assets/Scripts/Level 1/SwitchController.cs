using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchController : MonoBehaviour 
{

    private Animator switchAnimation;  
    private bool active = true; 

    public GameObject message;

    private enum switchStates
    {
        off,
        on
    };

    void Start() 
    {
        switchAnimation = GetComponent<Animator>();
        
    }


    public void switchOn()
    {
        switchStates state;
        state = switchStates.off;
        
        // Play switch Sound
        GameManager.instance.PlaySFX("switchPress");

        // Turn on Switch 
        if(active)
        {
            state = switchStates.on;
            active = false;
            message.SetActive(true);
        }

        switchAnimation.SetInteger("state", (int)state);
    } 
}
