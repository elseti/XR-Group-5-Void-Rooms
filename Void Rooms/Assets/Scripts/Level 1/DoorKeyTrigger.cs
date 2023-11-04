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
        print("entered trigger");
        if (GameManager.instance.GetKeyGrabbed())
        {
            print("door unlocked");
            this.gameObject.SetActive(false);
        }
        
    }
}
