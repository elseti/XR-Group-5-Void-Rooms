using UnityEngine;

public class AudioLoader : MonoBehaviour
{
    // BGM
    private AudioClip randomBGM;
    private AudioClip officeBGM;
    private AudioClip pianoBGM;

    // SFX
    private AudioClip doorCreak;
    private AudioClip phoneHangup;
    private AudioClip phoneDial;
    private AudioClip playerFootsteps;
    private AudioClip keyDrop;
    private AudioClip pianoC;
    private AudioClip pianoCSharp;
    private AudioClip pianoD;
    private AudioClip pianoDSharp;
    private AudioClip pianoE;
    private AudioClip pianoF;
    private AudioClip pianoFSharp;
    private AudioClip pianoG;
    private AudioClip pianoGSharp;
    private AudioClip pianoA;
    private AudioClip pianoASharp;
    private AudioClip pianoB;
    private AudioClip pianoCHigh;

    void Awake()
    {
        // BGM
        // randomBGM = Resources.Load<AudioClip>("path");

        // select one of the BGMs for level 1 (office)
        officeBGM = Resources.Load<AudioClip>("Audio/BGM/Darkness and Horror");
        // officeBGM = Resources.Load<AudioClip>("Audio/BGM/music-box-for-suspenseful-scenes-166461");

        pianoBGM = Resources.Load<AudioClip>("Audio/BGM/FREE_BONUS_PIANO_THEME");

        // SFX
        doorCreak = Resources.Load<AudioClip>("Audio/Level 1/Door/squeaky-door-open-113212");
        phoneHangup = Resources.Load<AudioClip>("Audio/Level 1/Phone/hang-up-tone-103906");
        phoneDial = Resources.Load<AudioClip>("Audio/Level 1/Phone/phone-outgoing-call-72202");
        playerFootsteps = Resources.Load<AudioClip>("Audio/Footsteps/indoor-footsteps-6385");
        keyDrop = Resources.Load<AudioClip>("Audio/Level 1/Door/key drop on carpet edit");
        
        // Piano SFX
        pianoC = Resources.Load<AudioClip>("Audio/Level 2/Piano/Basic Notes/c");
        pianoCSharp = Resources.Load<AudioClip>("Audio/Level 2/Piano/Basic Notes/c#");
        pianoD = Resources.Load<AudioClip>("Audio/Level 2/Piano/Basic Notes/d");
        pianoDSharp = Resources.Load<AudioClip>("Audio/Level 2/Piano/Basic Notes/d#");
        pianoE = Resources.Load<AudioClip>("Audio/Level 2/Piano/Basic Notes/e");
        pianoF = Resources.Load<AudioClip>("Audio/Level 2/Piano/Basic Notes/f");
        pianoFSharp = Resources.Load<AudioClip>("Audio/Level 2/Piano/Basic Notes/f#");
        pianoG = Resources.Load<AudioClip>("Audio/Level 2/Piano/Basic Notes/g");
        pianoGSharp = Resources.Load<AudioClip>("Audio/Level 2/Piano/Basic Notes/g#");
        pianoA = Resources.Load<AudioClip>("Audio/Level 2/Piano/Basic Notes/a");
        pianoASharp = Resources.Load<AudioClip>("Audio/Level 2/Piano/Basic Notes/a#");
        pianoB = Resources.Load<AudioClip>("Audio/Level 2/Piano/Basic Notes/b");
        pianoCHigh = Resources.Load<AudioClip>("Audio/Level 2/Piano/Basic Notes/c6");

    }

    public AudioClip GetBGM(string audioName)
    {
        switch (audioName)
        {
            case "randomBGM":
                return randomBGM;

            case "officeBGM":
                return officeBGM;

            case "pianoBGM":
                return pianoBGM;

            default:
                return null;
        }
    }

    public AudioClip GetSFX(string audioName)
    {
        switch (audioName)
        { 
            case "doorCreak":
                return doorCreak;

            case "phoneHangup":
                return phoneHangup;

            case "phoneDial":
                return phoneDial;

            case "playerFootsteps":
                return playerFootsteps;

            case "keyDrop":
                return keyDrop;
            
            case "pianoC":
                return pianoC; 
            
            case "pianoC#":
               return pianoCSharp;
            
            case "pianoD":
                return pianoD; 
            
            case "pianoD#":
                return pianoDSharp;
            
            case "pianoE":
                return pianoE; 
            
            case "pianoF":
                return pianoF;
            
            case "pianoF#":
                return pianoFSharp; 
            
            case "pianoG":
                return pianoGSharp;
            
            case "pianoG#":
                return pianoGSharp; 
            
            case "pianoA":
                return pianoA;
            
            case "pianoA#":
                return pianoASharp; 
            
            case "pianoB":
                return pianoB;
            
            case "pianoCHigh":
                return pianoCHigh;
            
            default:
                return null;
        }
    }
}