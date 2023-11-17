using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyDropTest : MonoBehaviour
{
    // private bool isGrabbed;
    private bool isSelected;
    void Start()
    {
        isSelected = false;
        // isGrabbed = GameManager.instance.GetKeyGrabbed();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (isSelected && collision.gameObject.CompareTag("Ground"))
        {
            // The key is not grabbed and collided with an object with the "Ground" tag
            // Notify the GameManager that the key is dropped
            // GameManager.instance.SetKeyGrabbed(false);
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
