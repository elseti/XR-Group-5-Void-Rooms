using UnityEngine;

public class AudioLoader : MonoBehaviour
{
    // BGM
    private AudioClip randomBGM;


    // SFX
    private AudioClip doorCreak;

    void Awake(){
        // BGM
        // randomBGM = Resources.Load<AudioClip>("path");

        // SFX
        doorCreak = Resources.Load<AudioClip>("Audio/Level 1/Door/squeaky-door-open-113212");
    }

    public AudioClip GetBGM(string audioName){
        switch(audioName){
            case "randomBGM":
                return randomBGM;
            
            default:
                return null;
        }
    }

    public AudioClip GetSFX(string audioName){
        switch(audioName){
            case "doorCreak":
                return doorCreak;
            
            default:
                return null;
        }
    }
}