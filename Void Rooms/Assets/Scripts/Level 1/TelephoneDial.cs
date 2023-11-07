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
        // this.gameObject.GetComponent<Outline>().enabled = false;
        // play some wrong sound OR game over
        // GameManager.instance.PlaySFX("doorCreak");
    }
    
    public void OnSelectExit()
    {
        // this.gameObject.GetComponent<Outline>().enabled = false;
    }
}
