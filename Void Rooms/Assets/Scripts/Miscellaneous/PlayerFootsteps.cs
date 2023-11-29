using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.XR.Interaction.Toolkit;

public class PlayerFootsteps : MonoBehaviour
{
    public GameObject xrController;
    public bool onWater; 
    
    private Vector3 lastControllerPosition;
    private bool footstepsPlaying;
    
    private void Start()
    {
        onWater = false;
        lastControllerPosition = xrController.transform.position;
    }

    private void Update()
    {
        Vector3 currentControllerPosition = xrController.transform.position;
        float movementDelta = Vector3.Distance(lastControllerPosition, currentControllerPosition);

        if (movementDelta > 0.01f) // Adjust the threshold as needed
        {
            // The player is moving
            if (!footstepsPlaying)
            {
                GameManager.instance.PlayFootsteps(onWater);
                footstepsPlaying = true;
            }
        }
        else
        {
            if (footstepsPlaying)
            {
                footstepsPlaying = false;
                GameManager.instance.StopFootsteps();
            }
        }

        lastControllerPosition = currentControllerPosition;
    }

}

