using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{
    // Setup
    private AudioLoader audioLoader;
    public AudioSource bgmAudio;
    public AudioSource sfxAudio;
    public AudioSource footstepsAudio;
    
    // Level 1
    private bool keyGrabbed;
    private bool doorUnlocked;
    
    // Level 2
    public UnityEvent portalOpened;
    private bool balloonBroken1;
    private bool balloonBroken2;
    private bool balloonBroken3;
    private bool balloonBroken4;
    private bool balloonBroken5;
    private bool balloonBroken6;
   
    
    void Start()
    {
        audioLoader = GetComponent<AudioLoader>();
    }
    
    // General functions
    public void LoadScene(string sceneName)
    {
        
        // TODO- fade out (alter gaze vignette?)
        SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Single);
    }
    
    // Audio functions
    
    // To return audio clip
    public AudioClip GetBGM(string audioName)
    {
        AudioClip ac = audioLoader.GetBGM(audioName);
        if (ac != null) return ac;
        print("ERROR: BGM file \" + audioName + \" not found!");
        return null;
    }
    
    public AudioClip GetSFX(string audioName)
    {
        return audioLoader.GetSFX(audioName);
        // if (ac != null) return ac;
        // print("ERROR: SFX file \" + audioName + \" not found!");
        // return null;
    }
    
    // To play audio clip directly
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

    public void PlayFootsteps(bool water)
    {
        if(!water)
        {
            print("player foot");
            footstepsAudio.clip = GetSFX("playerFootsteps");
            footstepsAudio.Play();
        }
        else
        {
            print("water foot");
            footstepsAudio.clip = GetSFX("waterFootsteps");
            footstepsAudio.Play();
        }
        
    }

    public void StopFootsteps()
    {
        footstepsAudio.Stop();
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
    
    // Level 2 Methods
    public void SetBalloonBroken(int balloonNo)
    {
        switch (balloonNo)
        {
            case 1:
                balloonBroken1 = true;
                break;
            case 2:
                balloonBroken2 = true;
                break;
            case 3:
                balloonBroken3 = true;
                break;
            case 4:
                balloonBroken4 = true;
                break;
            case 5:
                balloonBroken5 = true;
                break;
            case 6:
                balloonBroken6 = true;
                break;
            default:
                print("INVALID BALLOON NUMBER");
                break;
        }
    }

    public bool GetBalloonBroken(int balloonNo)
    {
        switch (balloonNo)
        {
            case 1:
                return balloonBroken1;
            case 2:
                return balloonBroken2;
            case 3:
                return balloonBroken3;
            case 4:
                return balloonBroken4;
            case 5:
                return balloonBroken5;
            case 6:
                return balloonBroken6;
        }
        print("INVALID BALLOON NUMBER");
        return false;
    }
    
    // open portal to gameover / next scene if piano is solved
    // public void OpenPortal()
    // {
    //     portalOpened.Invoke();
    // }
    
    
    
    
}