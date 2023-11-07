using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TelephoneHangup : MonoBehaviour
{
    void Start()
    {
        
    }
    
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider col)
    {
        GameManager.instance.PlaySFX("phoneHangup");
        
    }

    private void OnTriggerExit()
    {
        GameManager.instance.StopSFX();
    }
}
