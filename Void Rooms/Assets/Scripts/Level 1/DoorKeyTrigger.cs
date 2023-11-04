using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorKeyTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

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
