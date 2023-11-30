using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IInteractable : MonoBehaviour
{
    public virtual void OnHoverEnter()
    {
        this.gameObject.GetComponent<Outline>().enabled = true;
    }

    public virtual void OnHoverExit()
    {
        this.gameObject.GetComponent<Outline>().enabled = false;
    }
    
}
