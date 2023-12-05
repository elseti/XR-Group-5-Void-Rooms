using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TelephoneHangup : IInteractable
{
 
    private void OnTriggerEnter(Collider col)
    {
        GameManager.instance.PlaySFX("phoneHangup");
        
    }

    private void OnTriggerExit()
    {
        GameManager.instance.StopSFX();
    }
    
    public void OnSelectEnter()
    {
        
    }
    
    public void OnSelectExit()
    {
        
    }
}
