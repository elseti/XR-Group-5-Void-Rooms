using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class PlayerFootsteps : MonoBehaviour
{
    public GameObject xrController;
    private Vector3 lastControllerPosition;

    private void Start()
    {
        lastControllerPosition = xrController.transform.position;
    }

    private void Update()
    {
        Vector3 currentControllerPosition = xrController.transform.position;
        float movementDelta = Vector3.Distance(lastControllerPosition, currentControllerPosition);

        if (movementDelta > 0.01f) // Adjust the threshold as needed
        {
            // The player is moving
            Debug.Log("Player is moving");
            GameManager.instance.PlaySFX("playerFootsteps");
        }
        else
        {
            // The player is not moving
            Debug.Log("Player is not moving");
            GameManager.instance.StopSFX();
        }

        lastControllerPosition = currentControllerPosition;
    }
}

