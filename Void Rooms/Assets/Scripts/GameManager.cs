using UnityEngine;
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

    void Start()
    {
        audioLoader = GetComponent<AudioLoader>();
    }

    void Update()
    {
        
    }
    
    // General functions
    public void LoadScene(string sceneName)
    {
        
        // TODO- fade out (alter gaze vignette?)
        SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Single);
    }
    
    // Audio functions
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

    public void PlayFootsteps()
    {
        footstepsAudio.Play();
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

    
    
    
    
}