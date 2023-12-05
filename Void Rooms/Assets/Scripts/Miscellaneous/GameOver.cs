using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : IInteractable
{
    public void OnSelectEnter() 
    {
        Application.Quit(0);
    }
}
