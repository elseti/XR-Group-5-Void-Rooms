using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyDrop : MonoBehaviour
{
    private bool isGrabbed;

    void Start()
    {
        isGrabbed = GameManager.instance.GetKeyGrabbed();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (!isGrabbed && collision.gameObject.CompareTag("Ground"))
        {
            // The key is not grabbed and collided with an object with the "Ground" tag
            // Notify the GameManager that the key is dropped
            GameManager.instance.SetKeyGrabbed(false);

            // Play key drop sound
            PlayKeyDropSound();
        }

    }

    public void PlayKeyDropSound()
    {
        GameManager.instance.PlaySFX("keyDrop");
    }
}
