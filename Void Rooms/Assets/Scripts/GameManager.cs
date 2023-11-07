using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    // Setup
    private AudioLoader audioLoader;
    public AudioSource bgmAudio;
    public AudioSource sfxAudio;
    
    // Level 1
    private bool keyGrabbed;
    private bool doorUnlocked;

    void Start()
    {
        audioLoader = GetComponent<AudioLoader>();
    }

    void Update()
    {
        
    }
    
    // Audio Loader functions
    public void PlayBGM(string audioName){
        AudioClip ac = audioLoader.GetBGM(audioName);
        if(ac != null){
            bgmAudio.PlayOneShot(ac);
        }
        else{
            print("ERROR: BGM file " + audioName + " not found!");
        }
    }

    public void StopBGM(){
        bgmAudio.Stop();
    }

    public void PlaySFX(string audioName){
        AudioClip ac = audioLoader.GetSFX(audioName);
        if(ac != null){
            sfxAudio.PlayOneShot(ac);
        }
        else{
            print("ERROR: SFX file " + audioName + " not found!");
        }
    }

    public void StopSFX()
    {
        sfxAudio.Stop();
    }
    
    // Level 1 Methods
    public void SetKeyGrabbed(bool grabbed)
    {
        print("keyGrabbed is set to " + grabbed);
        keyGrabbed = grabbed;
    }

    public bool GetKeyGrabbed()
    {
        return keyGrabbed;
    }

    
    
}