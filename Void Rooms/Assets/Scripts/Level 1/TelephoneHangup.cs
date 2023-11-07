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

    public void OnHoverEnter()
    {
        this.gameObject.GetComponent<Outline>().enabled = true;
    }
    public void OnHoverExit()
    {
        this.gameObject.GetComponent<Outline>().enabled = true;
    }

    public void OnSelectEnter()
    {
        // this.gameObject.GetComponent<Outline>().enabled = false;
    }
    
    public void OnSelectExit()
    {
        // this.gameObject.GetComponent<Outline>().enabled = false;
    }
}
