using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorKeyTrigger : MonoBehaviour
{
   
    private void OnTriggerEnter()
    {
        print("entered door trigger");
        if (GameManager.instance.GetKeyGrabbed())
        {
            // TODO - sound of key unlocking?
            print("door unlocked");
            this.gameObject.GetComponent<Animator>().Play("Door Open");
        }
    }
    
    public void PlayDoorOpenSFX()
    {
        GameManager.instance.PlaySFX("doorCreak");
    }

}
