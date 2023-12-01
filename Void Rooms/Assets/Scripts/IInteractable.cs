using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IInteractable : MonoBehaviour
{
    public void OnHoverEnter()
    {
        this.gameObject.GetComponent<Outline>().enabled = true;
    }

    public void OnHoverExit()
    {
        this.gameObject.GetComponent<Outline>().enabled = false;
    }
    
}
