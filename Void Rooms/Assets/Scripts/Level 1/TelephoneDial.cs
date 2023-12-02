using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TelephoneDial : IInteractable
{
    void Start()
    {
        
    }
    
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider col)
    {
        GameManager.instance.PlaySFX("phoneDial");
        
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
