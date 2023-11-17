using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyDrop : MonoBehaviour
{
    private bool isSelected;
    void Start()
    {
        isSelected = false;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (isSelected && collision.gameObject.CompareTag("Ground"))
        {
            // The key is not grabbed and collided with an object with the "Ground" tag
            isSelected = false;
            
            // Play key drop sound
            PlayKeyDropSound();
        }

    }

    public void PlayKeyDropSound()
    {
        GameManager.instance.PlaySFX("keyDrop");
    }

    public void SetSelected(bool set)
    {
        isSelected = set;
    }
}
