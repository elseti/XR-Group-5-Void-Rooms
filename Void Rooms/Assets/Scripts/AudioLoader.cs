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
    private AudioClip switchPress;

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
        switchPress = Resources.Load<AudioClip>("Audio/Level 1/Switch/switchPress");

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

            case "switchPress":
                return switchPress;

            default:
                return null;
        }
    }
}