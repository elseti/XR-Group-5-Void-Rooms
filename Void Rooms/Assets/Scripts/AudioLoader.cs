using UnityEngine;

public class AudioLoader : MonoBehaviour
{
    // BGM
    private AudioClip randomBGM;


    // SFX
    private AudioClip doorCreak;
    private AudioClip phoneHangup;
    private AudioClip phoneDial;

    void Awake(){
        // BGM
        // randomBGM = Resources.Load<AudioClip>("path");

        // SFX
        doorCreak = Resources.Load<AudioClip>("Audio/Level 1/Door/squeaky-door-open-113212");
        phoneHangup = Resources.Load<AudioClip>("Audio/Level 1/Phone/hang-up-tone-103906");
        phoneDial = Resources.Load<AudioClip>("Audio/Level 1/Phone/phone-outgoing-call-72202");

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
            
            case "phoneHangup":
                return phoneHangup;
            
            case "phoneDial":
                return phoneDial;
            
            default:
                return null;
        }
    }
}