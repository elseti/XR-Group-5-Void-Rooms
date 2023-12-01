using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundTrigger : MonoBehaviour
{

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            print("player detected");
            GameManager.instance.gameObject.GetComponent<PlayerFootsteps>().onWater = false;
        }
    }

    private void OnTriggerExit(Collider col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            print("player out");
            GameManager.instance.gameObject.GetComponent<PlayerFootsteps>().onWater = true;
        }
    }
    
}
