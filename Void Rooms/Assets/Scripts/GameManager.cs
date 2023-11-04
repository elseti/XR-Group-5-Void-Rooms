using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    // Level 1
    private bool keyGrabbed;
    private bool doorUnlocked;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void SetKeyGrabbed(bool grabbed)
    {
        print("keyGrabbed is set to " + grabbed);
        keyGrabbed = grabbed;
    }

    public bool GetKeyGrabbed()
    {
        return keyGrabbed;
    }

    public void UnlockLevelOneDoor(bool unlocked)
    {
        doorUnlocked = unlocked;
    }
}